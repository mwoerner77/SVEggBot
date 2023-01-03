namespace SVEggBot
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelSwitchIP = new System.Windows.Forms.Label();
            this.InputSwitchIP = new System.Windows.Forms.TextBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ConnectionStatusText = new System.Windows.Forms.Label();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.ButtonStartPicnic = new System.Windows.Forms.Button();
            this.ButtonStopPicnic = new System.Windows.Forms.Button();
            this.RecipeRightCountLabel = new System.Windows.Forms.Label();
            this.RecipeDownCountLabel = new System.Windows.Forms.Label();
            this.RecipeRightCountInput = new System.Windows.Forms.NumericUpDown();
            this.RecipeDownCountInput = new System.Windows.Forms.NumericUpDown();
            this.StartingBoxNumberLabel = new System.Windows.Forms.Label();
            this.StartingBoxNumberInput = new System.Windows.Forms.NumericUpDown();
            this.baseInputDelayLabel = new System.Windows.Forms.Label();
            this.openHomeMenuDelayLabel = new System.Windows.Forms.Label();
            this.delaySettingsHeader = new System.Windows.Forms.Label();
            this.closeGameDelayLabel = new System.Windows.Forms.Label();
            this.picnicStartDelayLabel = new System.Windows.Forms.Label();
            this.sandwichIngredientTravelTimeLabel = new System.Windows.Forms.Label();
            this.sandwichStartDelayLabel = new System.Windows.Forms.Label();
            this.walkToTableTimeLabel = new System.Windows.Forms.Label();
            this.walkLeftToBasketTimeLabel = new System.Windows.Forms.Label();
            this.walkForwardToBasketLabel = new System.Windows.Forms.Label();
            this.walkRightToBasketTimeLabel = new System.Windows.Forms.Label();
            this.gameStartupDelayLabel = new System.Windows.Forms.Label();
            this.BaseInputDelay = new System.Windows.Forms.NumericUpDown();
            this.HomeMenuDelay = new System.Windows.Forms.NumericUpDown();
            this.CloseGameDelay = new System.Windows.Forms.NumericUpDown();
            this.PicnicStartDelay = new System.Windows.Forms.NumericUpDown();
            this.SandwichIngredientTravelTime = new System.Windows.Forms.NumericUpDown();
            this.WalkToTableTime = new System.Windows.Forms.NumericUpDown();
            this.WalkToBasketLeft = new System.Windows.Forms.NumericUpDown();
            this.WalkToBasketForward = new System.Windows.Forms.NumericUpDown();
            this.WalkToBasketRight = new System.Windows.Forms.NumericUpDown();
            this.GameStartupDelay = new System.Windows.Forms.NumericUpDown();
            this.SandwichStartTime = new System.Windows.Forms.NumericUpDown();
            this.TestSandwichMaking = new System.Windows.Forms.Button();
            this.TestBasketWalk = new System.Windows.Forms.Button();
            this.TestPicnicSetup = new System.Windows.Forms.Button();
            this.TestGameReset = new System.Windows.Forms.Button();
            this.BasketAPressesLabel = new System.Windows.Forms.Label();
            this.BasketDialogInputDelayLabel = new System.Windows.Forms.Label();
            this.BasketAPresses = new System.Windows.Forms.NumericUpDown();
            this.BasketDialogInputDelay = new System.Windows.Forms.NumericUpDown();
            this.TestBasketDialog = new System.Windows.Forms.Button();
            this.TimeBetweenBasketChecksLabel = new System.Windows.Forms.Label();
            this.TimeBetweenBasketChecks = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeRightCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDownCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingBoxNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInputDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeMenuDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseGameDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicnicStartDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SandwichIngredientTravelTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkToTableTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkToBasketLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkToBasketForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkToBasketRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameStartupDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SandwichStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasketAPresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasketDialogInputDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBetweenBasketChecks)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSwitchIP
            // 
            this.LabelSwitchIP.AutoSize = true;
            this.LabelSwitchIP.Location = new System.Drawing.Point(28, 19);
            this.LabelSwitchIP.Name = "LabelSwitchIP";
            this.LabelSwitchIP.Size = new System.Drawing.Size(58, 15);
            this.LabelSwitchIP.TabIndex = 0;
            this.LabelSwitchIP.Text = "Switch IP:";
            // 
            // InputSwitchIP
            // 
            this.InputSwitchIP.Location = new System.Drawing.Point(105, 16);
            this.InputSwitchIP.Name = "InputSwitchIP";
            this.InputSwitchIP.Size = new System.Drawing.Size(133, 23);
            this.InputSwitchIP.TabIndex = 1;
            this.InputSwitchIP.Text = "www.www.www.www";
            this.InputSwitchIP.TextChanged += new System.EventHandler(this.InputSwitchIP_TextChanged);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(44, 47);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(42, 15);
            this.LabelStatus.TabIndex = 2;
            this.LabelStatus.Text = "Status:";
            // 
            // ConnectionStatusText
            // 
            this.ConnectionStatusText.AutoSize = true;
            this.ConnectionStatusText.Location = new System.Drawing.Point(105, 47);
            this.ConnectionStatusText.Name = "ConnectionStatusText";
            this.ConnectionStatusText.Size = new System.Drawing.Size(88, 15);
            this.ConnectionStatusText.TabIndex = 3;
            this.ConnectionStatusText.Text = "Not Connected";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(28, 65);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(95, 25);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Location = new System.Drawing.Point(143, 65);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(95, 25);
            this.ButtonDisconnect.TabIndex = 5;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // ButtonStartPicnic
            // 
            this.ButtonStartPicnic.Location = new System.Drawing.Point(28, 96);
            this.ButtonStartPicnic.Name = "ButtonStartPicnic";
            this.ButtonStartPicnic.Size = new System.Drawing.Size(95, 25);
            this.ButtonStartPicnic.TabIndex = 6;
            this.ButtonStartPicnic.Text = "Start Picnic";
            this.ButtonStartPicnic.UseVisualStyleBackColor = true;
            this.ButtonStartPicnic.Click += new System.EventHandler(this.ButtonStartPicnic_Click);
            // 
            // ButtonStopPicnic
            // 
            this.ButtonStopPicnic.Location = new System.Drawing.Point(143, 96);
            this.ButtonStopPicnic.Name = "ButtonStopPicnic";
            this.ButtonStopPicnic.Size = new System.Drawing.Size(95, 25);
            this.ButtonStopPicnic.TabIndex = 7;
            this.ButtonStopPicnic.Text = "Stop Picnic";
            this.ButtonStopPicnic.UseVisualStyleBackColor = true;
            this.ButtonStopPicnic.Click += new System.EventHandler(this.ButtonStopPicnic_Click);
            // 
            // RecipeRightCountLabel
            // 
            this.RecipeRightCountLabel.AutoSize = true;
            this.RecipeRightCountLabel.Location = new System.Drawing.Point(31, 133);
            this.RecipeRightCountLabel.Name = "RecipeRightCountLabel";
            this.RecipeRightCountLabel.Size = new System.Drawing.Size(129, 15);
            this.RecipeRightCountLabel.TabIndex = 8;
            this.RecipeRightCountLabel.Text = "Right Presses To Recipe";
            // 
            // RecipeDownCountLabel
            // 
            this.RecipeDownCountLabel.AutoSize = true;
            this.RecipeDownCountLabel.Location = new System.Drawing.Point(28, 162);
            this.RecipeDownCountLabel.Name = "RecipeDownCountLabel";
            this.RecipeDownCountLabel.Size = new System.Drawing.Size(132, 15);
            this.RecipeDownCountLabel.TabIndex = 9;
            this.RecipeDownCountLabel.Text = "Down Presses To Recipe";
            // 
            // RecipeRightCountInput
            // 
            this.RecipeRightCountInput.Location = new System.Drawing.Point(163, 131);
            this.RecipeRightCountInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RecipeRightCountInput.Name = "RecipeRightCountInput";
            this.RecipeRightCountInput.Size = new System.Drawing.Size(75, 23);
            this.RecipeRightCountInput.TabIndex = 10;
            this.RecipeRightCountInput.ValueChanged += new System.EventHandler(this.RecipeRightCountInput_ValueChanged);
            // 
            // RecipeDownCountInput
            // 
            this.RecipeDownCountInput.Location = new System.Drawing.Point(163, 160);
            this.RecipeDownCountInput.Name = "RecipeDownCountInput";
            this.RecipeDownCountInput.Size = new System.Drawing.Size(75, 23);
            this.RecipeDownCountInput.TabIndex = 11;
            this.RecipeDownCountInput.ValueChanged += new System.EventHandler(this.RecipeDownCountInput_ValueChanged);
            // 
            // StartingBoxNumberLabel
            // 
            this.StartingBoxNumberLabel.AutoSize = true;
            this.StartingBoxNumberLabel.Location = new System.Drawing.Point(79, 193);
            this.StartingBoxNumberLabel.Name = "StartingBoxNumberLabel";
            this.StartingBoxNumberLabel.Size = new System.Drawing.Size(81, 15);
            this.StartingBoxNumberLabel.TabIndex = 12;
            this.StartingBoxNumberLabel.Text = "Starting Box #";
            // 
            // StartingBoxNumberInput
            // 
            this.StartingBoxNumberInput.Location = new System.Drawing.Point(163, 191);
            this.StartingBoxNumberInput.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.StartingBoxNumberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingBoxNumberInput.Name = "StartingBoxNumberInput";
            this.StartingBoxNumberInput.Size = new System.Drawing.Size(75, 23);
            this.StartingBoxNumberInput.TabIndex = 13;
            this.StartingBoxNumberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingBoxNumberInput.ValueChanged += new System.EventHandler(this.StartingBoxNumberInput_ValueChanged);
            // 
            // baseInputDelayLabel
            // 
            this.baseInputDelayLabel.AutoSize = true;
            this.baseInputDelayLabel.Location = new System.Drawing.Point(363, 39);
            this.baseInputDelayLabel.Name = "baseInputDelayLabel";
            this.baseInputDelayLabel.Size = new System.Drawing.Size(131, 15);
            this.baseInputDelayLabel.TabIndex = 14;
            this.baseInputDelayLabel.Text = "Base delay for all inputs";
            // 
            // openHomeMenuDelayLabel
            // 
            this.openHomeMenuDelayLabel.AutoSize = true;
            this.openHomeMenuDelayLabel.Location = new System.Drawing.Point(357, 68);
            this.openHomeMenuDelayLabel.Name = "openHomeMenuDelayLabel";
            this.openHomeMenuDelayLabel.Size = new System.Drawing.Size(137, 15);
            this.openHomeMenuDelayLabel.TabIndex = 15;
            this.openHomeMenuDelayLabel.Text = "Open Home Menu delay";
            // 
            // delaySettingsHeader
            // 
            this.delaySettingsHeader.AutoSize = true;
            this.delaySettingsHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delaySettingsHeader.Location = new System.Drawing.Point(368, 16);
            this.delaySettingsHeader.Name = "delaySettingsHeader";
            this.delaySettingsHeader.Size = new System.Drawing.Size(126, 15);
            this.delaySettingsHeader.TabIndex = 16;
            this.delaySettingsHeader.Text = "Input Settings (in ms)";
            // 
            // closeGameDelayLabel
            // 
            this.closeGameDelayLabel.AutoSize = true;
            this.closeGameDelayLabel.Location = new System.Drawing.Point(366, 97);
            this.closeGameDelayLabel.Name = "closeGameDelayLabel";
            this.closeGameDelayLabel.Size = new System.Drawing.Size(128, 15);
            this.closeGameDelayLabel.TabIndex = 17;
            this.closeGameDelayLabel.Text = "Delay for closing game";
            // 
            // picnicStartDelayLabel
            // 
            this.picnicStartDelayLabel.AutoSize = true;
            this.picnicStartDelayLabel.Location = new System.Drawing.Point(362, 126);
            this.picnicStartDelayLabel.Name = "picnicStartDelayLabel";
            this.picnicStartDelayLabel.Size = new System.Drawing.Size(132, 15);
            this.picnicStartDelayLabel.TabIndex = 18;
            this.picnicStartDelayLabel.Text = "Delay for starting picnic";
            // 
            // sandwichIngredientTravelTimeLabel
            // 
            this.sandwichIngredientTravelTimeLabel.AutoSize = true;
            this.sandwichIngredientTravelTimeLabel.Location = new System.Drawing.Point(320, 184);
            this.sandwichIngredientTravelTimeLabel.Name = "sandwichIngredientTravelTimeLabel";
            this.sandwichIngredientTravelTimeLabel.Size = new System.Drawing.Size(174, 15);
            this.sandwichIngredientTravelTimeLabel.TabIndex = 19;
            this.sandwichIngredientTravelTimeLabel.Text = "Sandwich Ingredient travel time";
            // 
            // sandwichStartDelayLabel
            // 
            this.sandwichStartDelayLabel.AutoSize = true;
            this.sandwichStartDelayLabel.Location = new System.Drawing.Point(344, 155);
            this.sandwichStartDelayLabel.Name = "sandwichStartDelayLabel";
            this.sandwichStartDelayLabel.Size = new System.Drawing.Size(150, 15);
            this.sandwichStartDelayLabel.TabIndex = 20;
            this.sandwichStartDelayLabel.Text = "Delay for starting sandwich";
            // 
            // walkToTableTimeLabel
            // 
            this.walkToTableTimeLabel.AutoSize = true;
            this.walkToTableTimeLabel.Location = new System.Drawing.Point(391, 213);
            this.walkToTableTimeLabel.Name = "walkToTableTimeLabel";
            this.walkToTableTimeLabel.Size = new System.Drawing.Size(103, 15);
            this.walkToTableTimeLabel.TabIndex = 21;
            this.walkToTableTimeLabel.Text = "Walk to table time";
            // 
            // walkLeftToBasketTimeLabel
            // 
            this.walkLeftToBasketTimeLabel.AutoSize = true;
            this.walkLeftToBasketTimeLabel.Location = new System.Drawing.Point(286, 242);
            this.walkLeftToBasketTimeLabel.Name = "walkLeftToBasketTimeLabel";
            this.walkLeftToBasketTimeLabel.Size = new System.Drawing.Size(208, 15);
            this.walkLeftToBasketTimeLabel.TabIndex = 22;
            this.walkLeftToBasketTimeLabel.Text = "Walk to basket time part 1 (facing left)";
            // 
            // walkForwardToBasketLabel
            // 
            this.walkForwardToBasketLabel.AutoSize = true;
            this.walkForwardToBasketLabel.Location = new System.Drawing.Point(262, 271);
            this.walkForwardToBasketLabel.Name = "walkForwardToBasketLabel";
            this.walkForwardToBasketLabel.Size = new System.Drawing.Size(232, 15);
            this.walkForwardToBasketLabel.TabIndex = 23;
            this.walkForwardToBasketLabel.Text = "Walk to basket time part 2 (facing forward)";
            // 
            // walkRightToBasketTimeLabel
            // 
            this.walkRightToBasketTimeLabel.AutoSize = true;
            this.walkRightToBasketTimeLabel.Location = new System.Drawing.Point(278, 300);
            this.walkRightToBasketTimeLabel.Name = "walkRightToBasketTimeLabel";
            this.walkRightToBasketTimeLabel.Size = new System.Drawing.Size(216, 15);
            this.walkRightToBasketTimeLabel.TabIndex = 24;
            this.walkRightToBasketTimeLabel.Text = "Walk to basket time part 3 (facing right)";
            // 
            // gameStartupDelayLabel
            // 
            this.gameStartupDelayLabel.AutoSize = true;
            this.gameStartupDelayLabel.Location = new System.Drawing.Point(385, 329);
            this.gameStartupDelayLabel.Name = "gameStartupDelayLabel";
            this.gameStartupDelayLabel.Size = new System.Drawing.Size(109, 15);
            this.gameStartupDelayLabel.TabIndex = 25;
            this.gameStartupDelayLabel.Text = "Game startup delay";
            // 
            // BaseInputDelay
            // 
            this.BaseInputDelay.Location = new System.Drawing.Point(506, 37);
            this.BaseInputDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BaseInputDelay.Name = "BaseInputDelay";
            this.BaseInputDelay.Size = new System.Drawing.Size(75, 23);
            this.BaseInputDelay.TabIndex = 26;
            this.BaseInputDelay.ValueChanged += new System.EventHandler(this.baseInputDelay_ValueChanged);
            // 
            // HomeMenuDelay
            // 
            this.HomeMenuDelay.Location = new System.Drawing.Point(506, 66);
            this.HomeMenuDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.HomeMenuDelay.Name = "HomeMenuDelay";
            this.HomeMenuDelay.Size = new System.Drawing.Size(75, 23);
            this.HomeMenuDelay.TabIndex = 27;
            this.HomeMenuDelay.ValueChanged += new System.EventHandler(this.homeMenuDelay_ValueChanged);
            // 
            // CloseGameDelay
            // 
            this.CloseGameDelay.Location = new System.Drawing.Point(506, 95);
            this.CloseGameDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CloseGameDelay.Name = "CloseGameDelay";
            this.CloseGameDelay.Size = new System.Drawing.Size(75, 23);
            this.CloseGameDelay.TabIndex = 28;
            this.CloseGameDelay.ValueChanged += new System.EventHandler(this.CloseGameDelay_ValueChanged);
            // 
            // PicnicStartDelay
            // 
            this.PicnicStartDelay.Location = new System.Drawing.Point(506, 124);
            this.PicnicStartDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PicnicStartDelay.Name = "PicnicStartDelay";
            this.PicnicStartDelay.Size = new System.Drawing.Size(75, 23);
            this.PicnicStartDelay.TabIndex = 29;
            this.PicnicStartDelay.ValueChanged += new System.EventHandler(this.PicnicStartDelay_ValueChanged);
            // 
            // SandwichIngredientTravelTime
            // 
            this.SandwichIngredientTravelTime.Location = new System.Drawing.Point(506, 182);
            this.SandwichIngredientTravelTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SandwichIngredientTravelTime.Name = "SandwichIngredientTravelTime";
            this.SandwichIngredientTravelTime.Size = new System.Drawing.Size(75, 23);
            this.SandwichIngredientTravelTime.TabIndex = 30;
            this.SandwichIngredientTravelTime.ValueChanged += new System.EventHandler(this.SandwichIngredientTravelTime_ValueChanged);
            // 
            // WalkToTableTime
            // 
            this.WalkToTableTime.Location = new System.Drawing.Point(506, 211);
            this.WalkToTableTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WalkToTableTime.Name = "WalkToTableTime";
            this.WalkToTableTime.Size = new System.Drawing.Size(75, 23);
            this.WalkToTableTime.TabIndex = 31;
            this.WalkToTableTime.ValueChanged += new System.EventHandler(this.WalkToTableTime_ValueChanged);
            // 
            // WalkToBasketLeft
            // 
            this.WalkToBasketLeft.Location = new System.Drawing.Point(506, 240);
            this.WalkToBasketLeft.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WalkToBasketLeft.Name = "WalkToBasketLeft";
            this.WalkToBasketLeft.Size = new System.Drawing.Size(75, 23);
            this.WalkToBasketLeft.TabIndex = 32;
            this.WalkToBasketLeft.ValueChanged += new System.EventHandler(this.WalkToBasketLeft_ValueChanged);
            // 
            // WalkToBasketForward
            // 
            this.WalkToBasketForward.Location = new System.Drawing.Point(506, 269);
            this.WalkToBasketForward.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WalkToBasketForward.Name = "WalkToBasketForward";
            this.WalkToBasketForward.Size = new System.Drawing.Size(75, 23);
            this.WalkToBasketForward.TabIndex = 33;
            this.WalkToBasketForward.ValueChanged += new System.EventHandler(this.WalkToBasketForward_ValueChanged);
            // 
            // WalkToBasketRight
            // 
            this.WalkToBasketRight.Location = new System.Drawing.Point(506, 298);
            this.WalkToBasketRight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WalkToBasketRight.Name = "WalkToBasketRight";
            this.WalkToBasketRight.Size = new System.Drawing.Size(75, 23);
            this.WalkToBasketRight.TabIndex = 34;
            this.WalkToBasketRight.ValueChanged += new System.EventHandler(this.WalkToBasketRight_ValueChanged);
            // 
            // GameStartupDelay
            // 
            this.GameStartupDelay.Location = new System.Drawing.Point(506, 327);
            this.GameStartupDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.GameStartupDelay.Name = "GameStartupDelay";
            this.GameStartupDelay.Size = new System.Drawing.Size(75, 23);
            this.GameStartupDelay.TabIndex = 35;
            this.GameStartupDelay.ValueChanged += new System.EventHandler(this.GameStartupDelay_ValueChanged);
            // 
            // SandwichStartTime
            // 
            this.SandwichStartTime.Location = new System.Drawing.Point(506, 153);
            this.SandwichStartTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SandwichStartTime.Name = "SandwichStartTime";
            this.SandwichStartTime.Size = new System.Drawing.Size(75, 23);
            this.SandwichStartTime.TabIndex = 36;
            this.SandwichStartTime.ValueChanged += new System.EventHandler(this.SandwichStartTime_ValueChanged);
            // 
            // TestSandwichMaking
            // 
            this.TestSandwichMaking.Location = new System.Drawing.Point(28, 280);
            this.TestSandwichMaking.Name = "TestSandwichMaking";
            this.TestSandwichMaking.Size = new System.Drawing.Size(210, 25);
            this.TestSandwichMaking.TabIndex = 37;
            this.TestSandwichMaking.Text = "Test Sandwich Making";
            this.TestSandwichMaking.UseVisualStyleBackColor = true;
            this.TestSandwichMaking.Click += new System.EventHandler(this.TestSandwichMaking_Click);
            // 
            // TestBasketWalk
            // 
            this.TestBasketWalk.Location = new System.Drawing.Point(28, 311);
            this.TestBasketWalk.Name = "TestBasketWalk";
            this.TestBasketWalk.Size = new System.Drawing.Size(210, 25);
            this.TestBasketWalk.TabIndex = 38;
            this.TestBasketWalk.Text = "Test Basket Walk";
            this.TestBasketWalk.UseVisualStyleBackColor = true;
            this.TestBasketWalk.Click += new System.EventHandler(this.TestBasketWalk_Click);
            // 
            // TestPicnicSetup
            // 
            this.TestPicnicSetup.Location = new System.Drawing.Point(28, 249);
            this.TestPicnicSetup.Name = "TestPicnicSetup";
            this.TestPicnicSetup.Size = new System.Drawing.Size(210, 25);
            this.TestPicnicSetup.TabIndex = 39;
            this.TestPicnicSetup.Text = "Test Picnic Setup";
            this.TestPicnicSetup.UseVisualStyleBackColor = true;
            this.TestPicnicSetup.Click += new System.EventHandler(this.TestPicnicSetup_Click);
            // 
            // TestGameReset
            // 
            this.TestGameReset.Location = new System.Drawing.Point(28, 342);
            this.TestGameReset.Name = "TestGameReset";
            this.TestGameReset.Size = new System.Drawing.Size(210, 25);
            this.TestGameReset.TabIndex = 40;
            this.TestGameReset.Text = "Test Game Reset";
            this.TestGameReset.UseVisualStyleBackColor = true;
            this.TestGameReset.Click += new System.EventHandler(this.TestGameReset_Click);
            // 
            // BasketAPressesLabel
            // 
            this.BasketAPressesLabel.AutoSize = true;
            this.BasketAPressesLabel.Location = new System.Drawing.Point(30, 222);
            this.BasketAPressesLabel.Name = "BasketAPressesLabel";
            this.BasketAPressesLabel.Size = new System.Drawing.Size(130, 15);
            this.BasketAPressesLabel.TabIndex = 41;
            this.BasketAPressesLabel.Text = "# of A Presses at Basket";
            // 
            // BasketDialogInputDelayLabel
            // 
            this.BasketDialogInputDelayLabel.AutoSize = true;
            this.BasketDialogInputDelayLabel.Location = new System.Drawing.Point(354, 358);
            this.BasketDialogInputDelayLabel.Name = "BasketDialogInputDelayLabel";
            this.BasketDialogInputDelayLabel.Size = new System.Drawing.Size(140, 15);
            this.BasketDialogInputDelayLabel.TabIndex = 42;
            this.BasketDialogInputDelayLabel.Text = "Basket Dialog input delay";
            // 
            // BasketAPresses
            // 
            this.BasketAPresses.Location = new System.Drawing.Point(163, 220);
            this.BasketAPresses.Name = "BasketAPresses";
            this.BasketAPresses.Size = new System.Drawing.Size(75, 23);
            this.BasketAPresses.TabIndex = 43;
            this.BasketAPresses.ValueChanged += new System.EventHandler(this.BasketAPresses_ValueChanged);
            // 
            // BasketDialogInputDelay
            // 
            this.BasketDialogInputDelay.Location = new System.Drawing.Point(506, 356);
            this.BasketDialogInputDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BasketDialogInputDelay.Name = "BasketDialogInputDelay";
            this.BasketDialogInputDelay.Size = new System.Drawing.Size(75, 23);
            this.BasketDialogInputDelay.TabIndex = 44;
            this.BasketDialogInputDelay.ValueChanged += new System.EventHandler(this.BasketDialogInputDelay_ValueChanged);
            // 
            // TestBasketDialog
            // 
            this.TestBasketDialog.Location = new System.Drawing.Point(28, 373);
            this.TestBasketDialog.Name = "TestBasketDialog";
            this.TestBasketDialog.Size = new System.Drawing.Size(210, 25);
            this.TestBasketDialog.TabIndex = 45;
            this.TestBasketDialog.Text = "Test Basket Dialog";
            this.TestBasketDialog.UseVisualStyleBackColor = true;
            this.TestBasketDialog.Click += new System.EventHandler(this.TestBasketDialog_Click);
            // 
            // TimeBetweenBasketChecksLabel
            // 
            this.TimeBetweenBasketChecksLabel.AutoSize = true;
            this.TimeBetweenBasketChecksLabel.Location = new System.Drawing.Point(337, 387);
            this.TimeBetweenBasketChecksLabel.Name = "TimeBetweenBasketChecksLabel";
            this.TimeBetweenBasketChecksLabel.Size = new System.Drawing.Size(157, 15);
            this.TimeBetweenBasketChecksLabel.TabIndex = 46;
            this.TimeBetweenBasketChecksLabel.Text = "Time between basket checks";
            // 
            // TimeBetweenBasketChecks
            // 
            this.TimeBetweenBasketChecks.Location = new System.Drawing.Point(506, 385);
            this.TimeBetweenBasketChecks.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TimeBetweenBasketChecks.Name = "TimeBetweenBasketChecks";
            this.TimeBetweenBasketChecks.Size = new System.Drawing.Size(75, 23);
            this.TimeBetweenBasketChecks.TabIndex = 47;
            this.TimeBetweenBasketChecks.ValueChanged += new System.EventHandler(this.TimeBetweenBasketChecks_ValueChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 430);
            this.Controls.Add(this.TimeBetweenBasketChecks);
            this.Controls.Add(this.TimeBetweenBasketChecksLabel);
            this.Controls.Add(this.TestBasketDialog);
            this.Controls.Add(this.BasketDialogInputDelay);
            this.Controls.Add(this.BasketAPresses);
            this.Controls.Add(this.BasketDialogInputDelayLabel);
            this.Controls.Add(this.BasketAPressesLabel);
            this.Controls.Add(this.TestGameReset);
            this.Controls.Add(this.TestPicnicSetup);
            this.Controls.Add(this.TestBasketWalk);
            this.Controls.Add(this.TestSandwichMaking);
            this.Controls.Add(this.SandwichStartTime);
            this.Controls.Add(this.GameStartupDelay);
            this.Controls.Add(this.WalkToBasketRight);
            this.Controls.Add(this.WalkToBasketForward);
            this.Controls.Add(this.WalkToBasketLeft);
            this.Controls.Add(this.WalkToTableTime);
            this.Controls.Add(this.SandwichIngredientTravelTime);
            this.Controls.Add(this.PicnicStartDelay);
            this.Controls.Add(this.CloseGameDelay);
            this.Controls.Add(this.HomeMenuDelay);
            this.Controls.Add(this.BaseInputDelay);
            this.Controls.Add(this.gameStartupDelayLabel);
            this.Controls.Add(this.walkRightToBasketTimeLabel);
            this.Controls.Add(this.walkForwardToBasketLabel);
            this.Controls.Add(this.walkLeftToBasketTimeLabel);
            this.Controls.Add(this.walkToTableTimeLabel);
            this.Controls.Add(this.sandwichStartDelayLabel);
            this.Controls.Add(this.sandwichIngredientTravelTimeLabel);
            this.Controls.Add(this.picnicStartDelayLabel);
            this.Controls.Add(this.closeGameDelayLabel);
            this.Controls.Add(this.delaySettingsHeader);
            this.Controls.Add(this.openHomeMenuDelayLabel);
            this.Controls.Add(this.baseInputDelayLabel);
            this.Controls.Add(this.StartingBoxNumberInput);
            this.Controls.Add(this.StartingBoxNumberLabel);
            this.Controls.Add(this.RecipeDownCountInput);
            this.Controls.Add(this.RecipeRightCountInput);
            this.Controls.Add(this.RecipeDownCountLabel);
            this.Controls.Add(this.RecipeRightCountLabel);
            this.Controls.Add(this.ButtonStopPicnic);
            this.Controls.Add(this.ButtonStartPicnic);
            this.Controls.Add(this.ButtonDisconnect);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.ConnectionStatusText);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.InputSwitchIP);
            this.Controls.Add(this.LabelSwitchIP);
            this.Name = "MainWindow";
            this.Text = "SV Egg Bot";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeRightCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDownCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingBoxNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseInputDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeMenuDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseGameDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicnicStartDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SandwichIngredientTravelTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkToTableTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkToBasketLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkToBasketForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkToBasketRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameStartupDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SandwichStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasketAPresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasketDialogInputDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBetweenBasketChecks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelSwitchIP;
        private TextBox InputSwitchIP;
        private Label LabelStatus;
        private Label ConnectionStatusText;
        private Button ButtonConnect;
        private Button ButtonDisconnect;
        private Button ButtonStartPicnic;
        private Button ButtonStopPicnic;
        private Label RecipeRightCountLabel;
        private Label RecipeDownCountLabel;
        private NumericUpDown RecipeRightCountInput;
        private NumericUpDown RecipeDownCountInput;
        private Label StartingBoxNumberLabel;
        private NumericUpDown StartingBoxNumberInput;
        private Label baseInputDelayLabel;
        private Label openHomeMenuDelayLabel;
        private Label delaySettingsHeader;
        private Label closeGameDelayLabel;
        private Label picnicStartDelayLabel;
        private Label sandwichIngredientTravelTimeLabel;
        private Label sandwichStartDelayLabel;
        private Label walkToTableTimeLabel;
        private Label walkLeftToBasketTimeLabel;
        private Label walkForwardToBasketLabel;
        private Label walkRightToBasketTimeLabel;
        private Label gameStartupDelayLabel;
        private NumericUpDown BaseInputDelay;
        private NumericUpDown HomeMenuDelay;
        private NumericUpDown CloseGameDelay;
        private NumericUpDown PicnicStartDelay;
        private NumericUpDown SandwichIngredientTravelTime;
        private NumericUpDown WalkToTableTime;
        private NumericUpDown WalkToBasketLeft;
        private NumericUpDown WalkToBasketForward;
        private NumericUpDown WalkToBasketRight;
        private NumericUpDown GameStartupDelay;
        private NumericUpDown SandwichStartTime;
        private Button TestSandwichMaking;
        private Button TestBasketWalk;
        private Button TestPicnicSetup;
        private Button TestGameReset;
        private Label BasketAPressesLabel;
        private Label BasketDialogInputDelayLabel;
        private NumericUpDown BasketAPresses;
        private NumericUpDown BasketDialogInputDelay;
        private Button TestBasketDialog;
        private Label TimeBetweenBasketChecksLabel;
        private NumericUpDown TimeBetweenBasketChecks;
    }
}