namespace SVEggBot
{
    using PKHeX.Core;
    using SysBot.Base;
    using System.Net.Sockets;
    using static SysBot.Base.SwitchButton;

    public partial class MainWindow : Form
    {
        private readonly static SwitchConnectionConfig Config = new() { Protocol = SwitchProtocol.WiFi, IP = Settings.Default.SwitchIP, Port = 6000 };
        private readonly static SwitchSocketAsync SwitchConnection = new(Config);
        private readonly static OffsetUtil OffsetUtil = new(SwitchConnection);
        private bool StopPicnicFlag = false;
        private int SlotsRead = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InputSwitchIP_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "192.168.0.0")
            {
                Settings.Default.SwitchIP = textBox.Text;
                Config.IP = textBox.Text;
            }
            Settings.Default.Save();
        }

        private async void Connect()
        {
            if (!SwitchConnection.Connected)
            {
                try
                {
                    ConnectionStatusText.Text = "Connecting...";
                    SwitchConnection.Connect();
                    ConnectionStatusText.Text = "Connected!";
                    ButtonConnect.Enabled = false;
                    ButtonDisconnect.Enabled = true;
                    ButtonStartPicnic.Enabled = true;
                    ButtonStopPicnic.Enabled = false;
                    RecipeDownCountInput.Enabled = true;
                    RecipeRightCountInput.Enabled = true;
                    StartingBoxNumberInput.Enabled = true;
                    TestSandwichMaking.Enabled = true;
                    TestBasketWalk.Enabled = true;
                    TestPicnicSetup.Enabled = true;
                    TestBasketDialog.Enabled = true;
                    TestGameReset.Enabled = true;
                }
                catch (SocketException err)
                {
                    Disconnect();
                    if (err.Message.Contains("failed to respond") || err.Message.Contains("actively refused"))
                    {
                        ConnectionStatusText.Text = "Unable to connect.";
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        private static async void Disconnect()
        {
            if (SwitchConnection.Connected)
            {
                await SwitchConnection.SendAsync(SwitchCommand.DetachController(true), CancellationToken.None).ConfigureAwait(false);
                SwitchConnection.Disconnect();
            }
        }

        private static new async Task Click(SwitchButton button, int delay, CancellationToken token)
        {
            await SwitchConnection.SendAsync(SwitchCommand.Click(button, true), token).ConfigureAwait(false);
            await Task.Delay(delay, token).ConfigureAwait(false);
        }

        private static async Task Hold(SwitchButton b, int delay, CancellationToken token)
        {
            await SwitchConnection.SendAsync(SwitchCommand.Hold(b, true), token).ConfigureAwait(false);
            await Task.Delay(delay, token).ConfigureAwait(false);
        }

        private static async Task Release(SwitchButton b, int delay, CancellationToken token)
        {
            await SwitchConnection.SendAsync(SwitchCommand.Release(b, true), token).ConfigureAwait(false);
            await Task.Delay(delay, token).ConfigureAwait(false);
        }

        private enum StickDirection
        {
            Up,
            Down,
            Left,
            Right
        }

        private static async Task HoldStickInDirection(SwitchStick stick, StickDirection direction, int duration, int delay, CancellationToken token)
        {
            switch (direction)
            {
                case StickDirection.Up:
                    await SwitchConnection.SendAsync(SwitchCommand.SetStick(stick, 0, 19000, true), token).ConfigureAwait(false);
                    break;
                case StickDirection.Down:
                    await SwitchConnection.SendAsync(SwitchCommand.SetStick(stick, 0, -19000, true), token).ConfigureAwait(false);
                    break;
                case StickDirection.Left:
                    await SwitchConnection.SendAsync(SwitchCommand.SetStick(stick, -19000, 0, true), token).ConfigureAwait(false);
                    break;
                case StickDirection.Right:
                    await SwitchConnection.SendAsync(SwitchCommand.SetStick(stick, 19000, 0, true), token).ConfigureAwait(false);
                    break;
            }
            await Task.Delay(duration, token).ConfigureAwait(false);
            await SwitchConnection.SendAsync(SwitchCommand.ResetStick(stick, true), token).ConfigureAwait(false);
            await Task.Delay(delay, token).ConfigureAwait(false);
        }

        private async Task StartPicnic(CancellationToken token)
        {
            int BaseDelay = (int)Settings.Default.CfgBaseDelay;
            await Click(LSTICK, BaseDelay, token).ConfigureAwait(false); // Sometimes it seems like the first command doesn't go through so send this just in case

            while (!StopPicnicFlag)
            {
                // Start Picnic
                await SetupPicnic(token).ConfigureAwait(false);
                if (StopPicnicFlag) break;

                // Make Sandwich
                await MakeSandwich(token).ConfigureAwait(false);
                if (StopPicnicFlag) break;

                // Walk to Basket and get eggs
                await WalkToBasket(token).ConfigureAwait(false);
                if (StopPicnicFlag) break;

                for (int i = 0; i < 9; i++)
                {
                    await BasketDialog(token).ConfigureAwait(false);
                    if (StopPicnicFlag || await TestForShiny(token).ConfigureAwait(false))
                    {
                        StopPicnicFlag = false;
                        ButtonStartPicnic.Enabled = true;
                        ButtonStopPicnic.Enabled = false;
                        RecipeDownCountInput.Enabled = true;
                        RecipeRightCountInput.Enabled = true;
                        StartingBoxNumberInput.Enabled = true;
                        TestSandwichMaking.Enabled = true;
                        TestBasketWalk.Enabled = true;
                        TestPicnicSetup.Enabled = true;
                        TestBasketDialog.Enabled = true;
                        TestGameReset.Enabled = true;
                        ConnectionStatusText.Text = "Stopped Picnic";
                        return;
                    }

                    await Click(B, (int)Settings.Default.CfgBasketTimeBetweenChecks, token).ConfigureAwait(false);
                }

                // HOME Menu
                await RestartGame(token).ConfigureAwait(false);
            }

            StopPicnicFlag = false;
            ButtonStartPicnic.Enabled = true;
            ButtonStopPicnic.Enabled = false;
            RecipeDownCountInput.Enabled = true;
            RecipeRightCountInput.Enabled = true;
            StartingBoxNumberInput.Enabled = true;
            TestSandwichMaking.Enabled = true;
            TestBasketWalk.Enabled = true;
            TestPicnicSetup.Enabled = true;
            TestBasketDialog.Enabled = true;
            TestGameReset.Enabled = true;
            ConnectionStatusText.Text = "Stopped Picnic";
        }

        private async Task SetupPicnic(CancellationToken token)
        {
            int BaseDelay = (int)Settings.Default.CfgBaseDelay;
            await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Up, 100, BaseDelay, token).ConfigureAwait(false);
            await Click(L, BaseDelay, token).ConfigureAwait(false);
            await Click(X, BaseDelay, token).ConfigureAwait(false);
            await Click(DRIGHT, BaseDelay, token).ConfigureAwait(false);
            await Click(DDOWN, BaseDelay, token).ConfigureAwait(false);
            await Click(DDOWN, BaseDelay, token).ConfigureAwait(false);
            await Click(A, BaseDelay + (int)Settings.Default.CfgStartPicnic, token).ConfigureAwait(false);
            await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Up, (int)Settings.Default.CfgPreSandwichForwardWalk, BaseDelay, token).ConfigureAwait(false);
        }

        private async Task MakeSandwich(CancellationToken token)
        {
            int BaseDelay = (int)Settings.Default.CfgBaseDelay;
            await Click(A, BaseDelay + 1_000, token).ConfigureAwait(false);
            await Click(A, BaseDelay + 3_500, token).ConfigureAwait(false);
            for (int i = 0; i < (int)Settings.Default.CfgSandwichRightPresses; i++) await Click(DRIGHT, BaseDelay, token).ConfigureAwait(false);
            for (int i = 0; i < (int)Settings.Default.CfgSandwichDownPresses; i++) await Click(DDOWN, BaseDelay, token).ConfigureAwait(false);
            await Click(A, BaseDelay, token).ConfigureAwait(false);
            await Click(A, BaseDelay + (int)Settings.Default.CfgSandwichStart, token).ConfigureAwait(false);
            for (int i = 0; i < 3; i++)
            {
                await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Up, (int)Settings.Default.CfgSandwichIngredientDistance, BaseDelay, token).ConfigureAwait(false);
                await Hold(A, BaseDelay, token).ConfigureAwait(false);
                await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Down, (int)Settings.Default.CfgSandwichIngredientDistance, BaseDelay, token).ConfigureAwait(false);
                await Release(A, BaseDelay, token).ConfigureAwait(false);
            }

            await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Up, (int)Settings.Default.CfgSandwichIngredientDistance, BaseDelay, token).ConfigureAwait(false);
            await Click(A, BaseDelay + 1_500, token).ConfigureAwait(false);
            await Click(A, BaseDelay + 8_500, token).ConfigureAwait(false);
            await Click(A, BaseDelay + 22_500, token).ConfigureAwait(false);
            await Click(A, BaseDelay, token).ConfigureAwait(false);
        }

        private async Task WalkToBasket(CancellationToken token)
        {
            int BaseDelay = (int)Settings.Default.CfgBaseDelay;
            await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Left, 100, BaseDelay, token).ConfigureAwait(false);
            await Click(L, BaseDelay, token).ConfigureAwait(false);
            await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Up, (int)Settings.Default.CfgBasketLeftWalk, BaseDelay, token).ConfigureAwait(false);
            await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Right, 100, BaseDelay, token).ConfigureAwait(false);
            await Click(L, BaseDelay, token).ConfigureAwait(false);
            await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Up, (int)Settings.Default.CfgBasketForwardWalk, BaseDelay, token).ConfigureAwait(false);
            await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Right, 100, BaseDelay, token).ConfigureAwait(false);
            await Click(L, BaseDelay, token).ConfigureAwait(false);
            await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Up, (int)Settings.Default.CfgBasketRightWalk, BaseDelay, token).ConfigureAwait(false);
            //await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Down, (int)Settings.Default.CfgBasketBackWalk, BaseDelay, token).ConfigureAwait(false);
        }

        private async Task RestartGame(CancellationToken token)
        {
            int BaseDelay = (int)Settings.Default.CfgBaseDelay;
            await Click(HOME, (int)Settings.Default.CfgOpenHome + BaseDelay, token).ConfigureAwait(false);
            await Click(X, BaseDelay + 1_000, token).ConfigureAwait(false);
            await Click(A, BaseDelay + 1_000, token).ConfigureAwait(false);
            await Click(A, (int)Settings.Default.CfgCloseGame + BaseDelay, token).ConfigureAwait(false);
            await Click(A, BaseDelay + 1_000, token).ConfigureAwait(false);
            await Click(A, BaseDelay + (int)Settings.Default.CfgGameStartDelay, token).ConfigureAwait(false);
            await Click(A, BaseDelay + (int)Settings.Default.CfgGameStartDelay, token).ConfigureAwait(false);
        }

        private async Task BasketDialog(CancellationToken token)
        {
            int BaseDelay = (int)Settings.Default.CfgBaseDelay;
            await Click(A, BaseDelay + (int)Settings.Default.CfgBasketDialogInputDelay, token).ConfigureAwait(false);
            for (int i = 0; i < 45; i++)
            {
                await Click(A, BaseDelay + (int)Settings.Default.CfgBasketDialogInputDelay, token).ConfigureAwait(false);
            }

            await Click(B, BaseDelay + (int)Settings.Default.CfgBasketDialogInputDelay, token).ConfigureAwait(false);
            await Click(B, BaseDelay + (int)Settings.Default.CfgBasketDialogInputDelay, token).ConfigureAwait(false);
            await Click(B, BaseDelay + (int)Settings.Default.CfgBasketDialogInputDelay, token).ConfigureAwait(false);
            await Click(B, BaseDelay + (int)Settings.Default.CfgBasketDialogInputDelay, token).ConfigureAwait(false);
            await Click(B, BaseDelay + (int)Settings.Default.CfgBasketDialogInputDelay, token).ConfigureAwait(false);
        }

        private async Task<bool> TestForShiny(CancellationToken token)
        {
            int startingSlot = this.SlotsRead;
            int slotSize = 344;
            int boxSize = 30 * slotSize;
            int startingBox = (int)Settings.Default.StartingBox;
            int boxIndex = startingBox == 0 ? startingBox : startingBox - 1;
            var box1Start = await OffsetUtil.GetPointerAddress(Offsets.Box1Slot1Pointer, CancellationToken.None);
            for (int i = 0; i < 3; i++)
            {
                if (startingSlot < (i + 1) * 30)
                {
                    boxIndex = (boxIndex + i) % 32;
                    var boxStart = box1Start + (ulong)(boxIndex * boxSize);
                    for (int j = 0; j < 30; j++)
                    {
                        if (startingSlot < i * 30 + j)
                        {
                            var slotData = await SwitchConnection.ReadBytesAbsoluteAsync(boxStart + (ulong)(j * slotSize), slotSize, token);
                            PK9 slotPKM = new PK9(PokeCrypto.DecryptArray9(slotData));
                            if (slotPKM.PID != 0)
                            {
                                this.SlotsRead++;
                                if (slotPKM.IsShiny)
                                    return true;
                            }

                            if (startingSlot + 10 >= i * 30 + j)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void ButtonStartPicnic_Click(object sender, EventArgs e)
        {
            if (SwitchConnection.Connected)
            {
                ConnectionStatusText.Text = "Picnicing";
                ButtonStartPicnic.Enabled = false;
                ButtonStopPicnic.Enabled = true;
                RecipeDownCountInput.Enabled = false;
                RecipeRightCountInput.Enabled = false;
                StartingBoxNumberInput.Enabled = false;
                TestSandwichMaking.Enabled = false;
                TestBasketWalk.Enabled = false;
                TestPicnicSetup.Enabled = false;
                TestBasketDialog.Enabled = false;
                TestGameReset.Enabled = false;
                StartPicnic(CancellationToken.None);
            }
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
            ConnectionStatusText.Text = "Disconnected.";
            ButtonConnect.Enabled = true;
            ButtonDisconnect.Enabled = false;
            ButtonStartPicnic.Enabled = false;
            ButtonStopPicnic.Enabled = false;
            RecipeDownCountInput.Enabled = true;
            RecipeRightCountInput.Enabled = true;
            StartingBoxNumberInput.Enabled = true;
            TestSandwichMaking.Enabled = false;
            TestBasketWalk.Enabled = false;
            TestPicnicSetup.Enabled = false;
            TestBasketDialog.Enabled = false;
            TestGameReset.Enabled = false;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            InputSwitchIP.Text = Settings.Default.SwitchIP;
            RecipeDownCountInput.Value = Settings.Default.CfgSandwichDownPresses;
            RecipeRightCountInput.Value = Settings.Default.CfgSandwichRightPresses;
            StartingBoxNumberInput.Value = Settings.Default.StartingBox;
            BaseInputDelay.Value = Settings.Default.CfgBaseDelay;
            HomeMenuDelay.Value = Settings.Default.CfgOpenHome;
            CloseGameDelay.Value = Settings.Default.CfgCloseGame;
            PicnicStartDelay.Value = Settings.Default.CfgStartPicnic;
            SandwichIngredientTravelTime.Value = Settings.Default.CfgSandwichIngredientDistance;
            WalkToTableTime.Value = Settings.Default.CfgPreSandwichForwardWalk;
            WalkToBasketLeft.Value = Settings.Default.CfgBasketLeftWalk;
            WalkToBasketForward.Value = Settings.Default.CfgBasketForwardWalk;
            WalkToBasketRight.Value = Settings.Default.CfgBasketRightWalk;
            GameStartupDelay.Value = Settings.Default.CfgGameStartDelay;
            SandwichStartTime.Value = Settings.Default.CfgSandwichStart;
            BasketDialogInputDelay.Value = Settings.Default.CfgBasketDialogInputDelay;
            BasketAPresses.Value = Settings.Default.CfgBasketAPresses;
            TimeBetweenBasketChecks.Value = Settings.Default.CfgBasketTimeBetweenChecks;
            ButtonConnect.Enabled = true;
            ButtonDisconnect.Enabled = false;
            ButtonStartPicnic.Enabled = false;
            ButtonStopPicnic.Enabled = false;
            RecipeDownCountInput.Enabled = true;
            RecipeRightCountInput.Enabled = true;
            StartingBoxNumberInput.Enabled = true;
            TestSandwichMaking.Enabled = false;
            TestBasketWalk.Enabled = false;
            TestPicnicSetup.Enabled = false;
            TestBasketDialog.Enabled = false;
            TestGameReset.Enabled = false;
        }

        private void RecipeRightCountInput_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgSandwichRightPresses = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void RecipeDownCountInput_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgSandwichDownPresses = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void ButtonStopPicnic_Click(object sender, EventArgs e)
        {
            if (SwitchConnection.Connected)
            {
                StopPicnicFlag = true;
                ConnectionStatusText.Text = "Attempting to Stop Picnic";
            }
        }

        private void StartingBoxNumberInput_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.StartingBox = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void baseInputDelay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgBaseDelay = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void homeMenuDelay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgOpenHome = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void CloseGameDelay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgCloseGame = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void PicnicStartDelay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgStartPicnic = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void SandwichIngredientTravelTime_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgSandwichIngredientDistance = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void WalkToTableTime_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgPreSandwichForwardWalk = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void WalkToBasketLeft_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgBasketLeftWalk = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void WalkToBasketForward_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgBasketForwardWalk = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void WalkToBasketRight_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgBasketRightWalk = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void GameStartupDelay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgGameStartDelay = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void SandwichStartTime_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgSandwichStart = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void TestSandwichMaking_Click(object sender, EventArgs e)
        {
            MakeSandwich(CancellationToken.None);
        }

        private void TestBasketWalk_Click(object sender, EventArgs e)
        {
            WalkToBasket(CancellationToken.None);
        }

        private void TestPicnicSetup_Click(object sender, EventArgs e)
        {
            SetupPicnic(CancellationToken.None);
        }

        private void TestGameReset_Click(object sender, EventArgs e)
        {
            RestartGame(CancellationToken.None);
        }

        private void BasketDialogInputDelay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgBasketDialogInputDelay = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void BasketAPresses_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgBasketAPresses = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void TimeBetweenBasketChecks_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Settings.Default.CfgBasketTimeBetweenChecks = (int)numericUpDown.Value;
            Settings.Default.Save();
        }

        private void TestBasketDialog_Click(object sender, EventArgs e)
        {
            BasketDialog(CancellationToken.None);
        }
    }
}