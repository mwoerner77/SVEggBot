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
            ((System.ComponentModel.ISupportInitialize)(this.RecipeRightCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDownCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingBoxNumberInput)).BeginInit();
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 235);
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
    }
}