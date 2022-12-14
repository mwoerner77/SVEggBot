namespace SVAutoHatch
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
            int BaseDelay = 0_550 + (int)Settings.Default.CfgBaseDelay;
            await Click(LSTICK, BaseDelay, token).ConfigureAwait(false); // Sometimes it seems like the first command doesn't go through so send this just in case

            while (!StopPicnicFlag)
            {
                // Start Picnic
                await Click(X, BaseDelay, token).ConfigureAwait(false);
                await Click(DRIGHT, BaseDelay, token).ConfigureAwait(false);
                await Click(DDOWN, BaseDelay, token).ConfigureAwait(false);
                await Click(DDOWN, BaseDelay, token).ConfigureAwait(false);
                await Click(A, BaseDelay + (int)Settings.Default.CfgStartPicnic, token).ConfigureAwait(false);
                if (StopPicnicFlag) break;

                // Make Sandwich
                await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Up, (int)Settings.Default.CfgPreSandwichForwardWalk, BaseDelay, token).ConfigureAwait(false);
                await Click(A, BaseDelay + 1_000, token).ConfigureAwait(false);
                await Click(A, BaseDelay + 3_500, token).ConfigureAwait(false);
                for (int i = 0; i < (int)Settings.Default.CfgSandwichRightPresses; i++) await Click(DRIGHT, BaseDelay, token).ConfigureAwait(false);
                for (int i = 0; i < (int)Settings.Default.CfgSandwichDownPresses; i++) await Click(DDOWN, BaseDelay, token).ConfigureAwait(false);
                await Click(A, BaseDelay, token).ConfigureAwait(false);
                await Click(A, BaseDelay + (int)Settings.Default.CfgSandwichStart, token).ConfigureAwait(false);
                if (StopPicnicFlag) break;

                for (int i = 0; i < 3; i++)
                {
                    await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Up, (int)Settings.Default.CfgSandwichIngredientDistance, BaseDelay, token).ConfigureAwait(false);
                    await Hold(A, BaseDelay, token).ConfigureAwait(false);
                    await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Down, (int)Settings.Default.CfgSandwichIngredientDistance, BaseDelay, token).ConfigureAwait(false);
                    await Release(A, BaseDelay, token).ConfigureAwait(false);
                    if (StopPicnicFlag) break;
                }

                await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Up, (int)Settings.Default.CfgSandwichIngredientDistance, BaseDelay, token).ConfigureAwait(false);
                await Click(A, BaseDelay + 1_500, token).ConfigureAwait(false);
                await Click(A, BaseDelay + 8_500, token).ConfigureAwait(false);
                await Click(A, BaseDelay + 22_500, token).ConfigureAwait(false);
                await Click(A, BaseDelay, token).ConfigureAwait(false);
                if (StopPicnicFlag) break;

                // Walk to Basket and get eggs
                await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Left, (int)Settings.Default.CfgBasketLeftWalk, BaseDelay, token).ConfigureAwait(false);
                await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Up, (int)Settings.Default.CfgBasketForwardWalk, BaseDelay, token).ConfigureAwait(false);
                await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Right, (int)Settings.Default.CfgBasketRightWalk, BaseDelay, token).ConfigureAwait(false);
                //await HoldStickInDirection(SwitchStick.LEFT, StickDirection.Down, (int)Settings.Default.CfgBasketBackWalk, BaseDelay, token).ConfigureAwait(false);
                if (StopPicnicFlag) break;

                for (int i = 0; i < 9; i++)
                {
                    await Click(A, 0_750, token).ConfigureAwait(false);
                    for (int j = 0; j < 75; j++)
                    {
                        if (StopPicnicFlag)
                        {
                            StopPicnicFlag = false;
                            ButtonStartPicnic.Enabled = true;
                            ButtonStopPicnic.Enabled = false;
                            RecipeDownCountInput.Enabled = true;
                            RecipeRightCountInput.Enabled = true;
                            ConnectionStatusText.Text = "Stopped Picnic";
                            return;
                        }
                        await Click(B, 0_750, token).ConfigureAwait(false);
                    }
                    if (StopPicnicFlag || await TestForShiny(token).ConfigureAwait(false))
                    {
                        StopPicnicFlag = false;
                        ButtonStartPicnic.Enabled = true;
                        ButtonStopPicnic.Enabled = false;
                        RecipeDownCountInput.Enabled = true;
                        RecipeRightCountInput.Enabled = true;
                        ConnectionStatusText.Text = "Stopped Picnic";
                        return;
                    }
                    await Click(B, 150_000, token).ConfigureAwait(false);
                }

                // HOME Menu
                await Click(HOME, (int)Settings.Default.CfgOpenHome + BaseDelay, token).ConfigureAwait(false);
                await Click(X, BaseDelay + 1_000, token).ConfigureAwait(false);
                await Click(A, BaseDelay + 1_000, token).ConfigureAwait(false);
                await Click(A, (int)Settings.Default.CfgCloseGame + BaseDelay, token).ConfigureAwait(false);
                await Click(A, BaseDelay + 1_000, token).ConfigureAwait(false);
                await Click(A, BaseDelay + 20_000, token).ConfigureAwait(false);
                await Click(A, BaseDelay + 20_000, token).ConfigureAwait(false);
            }

            StopPicnicFlag = false;
            ButtonStartPicnic.Enabled = true;
            ButtonStopPicnic.Enabled = false;
            RecipeDownCountInput.Enabled = true;
            RecipeRightCountInput.Enabled = true;
            ConnectionStatusText.Text = "Stopped Picnic";
        }

        private async Task<bool> TestForShiny(CancellationToken token)
        {
            int slotSize = 344;
            int boxSize = 30 * slotSize;
            int startingBox = (int)Settings.Default.StartingBox;
            int boxIndex = startingBox == 0 ? startingBox : startingBox - 1;
            var box1Start = await OffsetUtil.GetPointerAddress(Offsets.Box1Slot1Pointer, CancellationToken.None);
            for (int i = 0; i < 3; i++)
            {
                boxIndex = (boxIndex + i) % 32;
                var boxStart = box1Start + (ulong)(boxIndex * boxSize);
                for (int j = 0; j < 30; j++)
                {
                    var slotData = await SwitchConnection.ReadBytesAbsoluteAsync(boxStart + (ulong)(j * slotSize), slotSize, token);
                    PK9 slotPKM = new PK9(PokeCrypto.DecryptArray9(slotData));
                    if (slotPKM.IsShiny && slotPKM.PID != 0)
                        return true;
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
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            InputSwitchIP.Text = Settings.Default.SwitchIP;
            RecipeDownCountInput.Value = Settings.Default.CfgSandwichDownPresses;
            RecipeRightCountInput.Value = Settings.Default.CfgSandwichRightPresses;
            ButtonConnect.Enabled = true;
            ButtonDisconnect.Enabled = false;
            ButtonStartPicnic.Enabled = false;
            ButtonStopPicnic.Enabled = false;
            RecipeDownCountInput.Enabled = true;
            RecipeRightCountInput.Enabled = true;
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
    }
}