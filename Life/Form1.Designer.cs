namespace Life
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectRulesDropDown = new System.Windows.Forms.ComboBox();
            this.ChangeRulesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FrequencyUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CellSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.MainCanvas = new System.Windows.Forms.PictureBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.MainColorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SelectRulesDropDown);
            this.groupBox1.Controls.Add(this.ChangeRulesButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CreateButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FrequencyUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CellSizeUpDown);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 761);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rules";
            // 
            // SelectRulesDropDown
            // 
            this.SelectRulesDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectRulesDropDown.FormattingEnabled = true;
            this.SelectRulesDropDown.Items.AddRange(new object[] {
            "Conway\'s Game of Life",
            "Day & Night",
            "HighLife",
            "Life without Death",
            "Seeds",
            "Custom"});
            this.SelectRulesDropDown.Location = new System.Drawing.Point(15, 161);
            this.SelectRulesDropDown.Name = "SelectRulesDropDown";
            this.SelectRulesDropDown.Size = new System.Drawing.Size(149, 23);
            this.SelectRulesDropDown.TabIndex = 11;
            this.SelectRulesDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectRulesDropDown_SelectedIndexChanged);
            // 
            // ChangeRulesButton
            // 
            this.ChangeRulesButton.Location = new System.Drawing.Point(170, 161);
            this.ChangeRulesButton.Name = "ChangeRulesButton";
            this.ChangeRulesButton.Size = new System.Drawing.Size(69, 24);
            this.ChangeRulesButton.TabIndex = 10;
            this.ChangeRulesButton.Text = "Edit";
            this.ChangeRulesButton.UseVisualStyleBackColor = true;
            this.ChangeRulesButton.Click += new System.EventHandler(this.ChangeRulesButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Colors";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Dead";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ColorDeadClick);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(26, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Alive";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ColorAliveClick);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(26, 94);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(69, 23);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "New";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Frequency";
            // 
            // FrequencyUpDown
            // 
            this.FrequencyUpDown.Location = new System.Drawing.Point(26, 65);
            this.FrequencyUpDown.Name = "FrequencyUpDown";
            this.FrequencyUpDown.Size = new System.Drawing.Size(69, 23);
            this.FrequencyUpDown.TabIndex = 4;
            this.FrequencyUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cell size";
            // 
            // CellSizeUpDown
            // 
            this.CellSizeUpDown.Location = new System.Drawing.Point(26, 36);
            this.CellSizeUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CellSizeUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CellSizeUpDown.Name = "CellSizeUpDown";
            this.CellSizeUpDown.Size = new System.Drawing.Size(69, 23);
            this.CellSizeUpDown.TabIndex = 2;
            this.CellSizeUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopButton.Location = new System.Drawing.Point(151, 726);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Location = new System.Drawing.Point(20, 726);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainCanvas
            // 
            this.MainCanvas.BackColor = System.Drawing.Color.Black;
            this.MainCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainCanvas.InitialImage = null;
            this.MainCanvas.Location = new System.Drawing.Point(256, 0);
            this.MainCanvas.Name = "MainCanvas";
            this.MainCanvas.Size = new System.Drawing.Size(1228, 761);
            this.MainCanvas.TabIndex = 1;
            this.MainCanvas.TabStop = false;
            this.MainCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainCanvasDraw);
            this.MainCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainCanvasDraw);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 50;
            this.UpdateTimer.Tick += new System.EventHandler(this.ImageUpdateTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.MainCanvas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Conway\'s Game of Life";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox MainCanvas;
        private System.Windows.Forms.Timer UpdateTimer;
        private Button StartButton;
        private Button StopButton;
        private Button CreateButton;
        private Label label2;
        private NumericUpDown FrequencyUpDown;
        private Label label1;
        private NumericUpDown CellSizeUpDown;
        private ColorDialog MainColorDialog;
        private Label label3;
        private Button button2;
        private Button button1;
        private Button ChangeRulesButton;
        private Label label4;
        private ComboBox SelectRulesDropDown;
    }
}