namespace SBKA
{
    partial class FrmSettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblOutputFreq;

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
            components = new System.ComponentModel.Container();
            tmrRefresh = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblLastSound = new Label();
            btnTest = new Button();
            lblLastPlayed = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            pbLevel = new ProgressBar();
            groupBox2 = new GroupBox();
            tbInterval = new TrackBar();
            lblInterval = new Label();
            label6 = new Label();
            lblDuration = new Label();
            label9 = new Label();
            tbOutputDuration = new TrackBar();
            lblOutputFreq = new Label();
            label5 = new Label();
            tbOutputFreq = new TrackBar();
            label7 = new Label();
            tbOutputBoost = new TrackBar();
            chkDisableWhenLocked = new CheckBox();
            chkDisablewithmonitor = new CheckBox();
            chkDisableDetection = new CheckBox();
            cbDevices = new ComboBox();
            tmrLevelIndicator = new System.Windows.Forms.Timer(components);
            cbTrayIcon = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            cbSampleRate = new ComboBox();
            chkStartup = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbOutputDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbOutputFreq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbOutputBoost).BeginInit();
            SuspendLayout();
            // 
            // tmrRefresh
            // 
            tmrRefresh.Enabled = true;
            tmrRefresh.Interval = 1000;
            tmrRefresh.Tick += tmrRefresh_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 41);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 0;
            label1.Text = "Last Sound Detected";
            // 
            // lblLastSound
            // 
            lblLastSound.AutoSize = true;
            lblLastSound.Location = new Point(290, 41);
            lblLastSound.Margin = new Padding(6, 0, 6, 0);
            lblLastSound.Name = "lblLastSound";
            lblLastSound.Size = new Size(56, 32);
            lblLastSound.TabIndex = 1;
            lblLastSound.Text = "N/A";
            // 
            // btnTest
            // 
            btnTest.Location = new Point(381, 143);
            btnTest.Margin = new Padding(6);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(139, 49);
            btnTest.TabIndex = 2;
            btnTest.Text = "TEST";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // lblLastPlayed
            // 
            lblLastPlayed.AutoSize = true;
            lblLastPlayed.Location = new Point(290, 98);
            lblLastPlayed.Margin = new Padding(6, 0, 6, 0);
            lblLastPlayed.Name = "lblLastPlayed";
            lblLastPlayed.Size = new Size(56, 32);
            lblLastPlayed.TabIndex = 4;
            lblLastPlayed.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 98);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(208, 32);
            label3.TabIndex = 3;
            label3.Text = "Last Sound Played";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbLevel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnTest);
            groupBox1.Controls.Add(lblLastPlayed);
            groupBox1.Controls.Add(lblLastSound);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(22, 26);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(537, 215);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detection && Test";
            // 
            // pbLevel
            // 
            pbLevel.Location = new Point(17, 158);
            pbLevel.Margin = new Padding(6);
            pbLevel.Name = "pbLevel";
            pbLevel.Size = new Size(293, 21);
            pbLevel.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbInterval);
            groupBox2.Controls.Add(lblInterval);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lblDuration);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(tbOutputDuration);
            groupBox2.Controls.Add(lblOutputFreq);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbOutputFreq);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbOutputBoost);
            groupBox2.Controls.Add(chkDisableWhenLocked);
            groupBox2.Controls.Add(chkDisablewithmonitor);
            groupBox2.Controls.Add(chkDisableDetection);
            groupBox2.Controls.Add(cbDevices);
            groupBox2.Location = new Point(20, 351);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(539, 725);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Audio Device";
            // 
            // tbInterval
            // 
            tbInterval.LargeChange = 10;
            tbInterval.Location = new Point(19, 619);
            tbInterval.Margin = new Padding(6);
            tbInterval.Maximum = 600;
            tbInterval.Minimum = 60;
            tbInterval.Name = "tbInterval";
            tbInterval.Size = new Size(503, 90);
            tbInterval.TabIndex = 12;
            tbInterval.TickFrequency = 30;
            tbInterval.Value = 60;
            tbInterval.ValueChanged += tbInterval_ValueChanged;
            // 
            // lblInterval
            // 
            lblInterval.AutoSize = true;
            lblInterval.Location = new Point(189, 581);
            lblInterval.Margin = new Padding(6, 0, 6, 0);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(136, 32);
            lblInterval.TabIndex = 0;
            lblInterval.Text = "10 Seconds";
            lblInterval.Click += lblInterval_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 581);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 32);
            label6.TabIndex = 0;
            label6.Text = "Interval";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(240, 492);
            lblDuration.Margin = new Padding(6, 0, 6, 0);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(113, 32);
            lblDuration.TabIndex = 0;
            lblDuration.Text = "1 Second";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 492);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(190, 32);
            label9.TabIndex = 0;
            label9.Text = "Output Duration";
            // 
            // tbOutputDuration
            // 
            tbOutputDuration.LargeChange = 3;
            tbOutputDuration.Location = new Point(19, 530);
            tbOutputDuration.Margin = new Padding(6);
            tbOutputDuration.Maximum = 15;
            tbOutputDuration.Minimum = 1;
            tbOutputDuration.Name = "tbOutputDuration";
            tbOutputDuration.Size = new Size(503, 90);
            tbOutputDuration.TabIndex = 11;
            tbOutputDuration.TickFrequency = 30;
            tbOutputDuration.Value = 1;
            tbOutputDuration.ValueChanged += tbOutputDuration_ValueChanged;
            // 
            // lblOutputFreq
            // 
            lblOutputFreq.AutoSize = true;
            lblOutputFreq.Location = new Point(240, 404);
            lblOutputFreq.Margin = new Padding(6, 0, 6, 0);
            lblOutputFreq.Name = "lblOutputFreq";
            lblOutputFreq.Size = new Size(68, 32);
            lblOutputFreq.TabIndex = 0;
            lblOutputFreq.Text = "10Hz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 404);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(208, 32);
            label5.TabIndex = 0;
            label5.Text = "Output Frequency";
            // 
            // tbOutputFreq
            // 
            tbOutputFreq.LargeChange = 20;
            tbOutputFreq.Location = new Point(19, 442);
            tbOutputFreq.Margin = new Padding(6);
            tbOutputFreq.Maximum = 440;
            tbOutputFreq.Minimum = 4;
            tbOutputFreq.Name = "tbOutputFreq";
            tbOutputFreq.Size = new Size(503, 90);
            tbOutputFreq.TabIndex = 10;
            tbOutputFreq.TickFrequency = 30;
            tbOutputFreq.TickStyle = TickStyle.None;
            tbOutputFreq.Value = 10;
            tbOutputFreq.ValueChanged += tbOutputFreq_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 316);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(157, 32);
            label7.TabIndex = 0;
            label7.Text = "Output Boost";
            // 
            // tbOutputBoost
            // 
            tbOutputBoost.LargeChange = 2;
            tbOutputBoost.Location = new Point(19, 354);
            tbOutputBoost.Margin = new Padding(6);
            tbOutputBoost.Minimum = 1;
            tbOutputBoost.Name = "tbOutputBoost";
            tbOutputBoost.Size = new Size(503, 90);
            tbOutputBoost.TabIndex = 9;
            tbOutputBoost.TickFrequency = 30;
            tbOutputBoost.Value = 1;
            tbOutputBoost.ValueChanged += tbOutputBoost_ValueChanged;
            // 
            // chkDisableWhenLocked
            // 
            chkDisableWhenLocked.AutoSize = true;
            chkDisableWhenLocked.Location = new Point(19, 264);
            chkDisableWhenLocked.Margin = new Padding(6);
            chkDisableWhenLocked.Name = "chkDisableWhenLocked";
            chkDisableWhenLocked.Size = new Size(345, 36);
            chkDisableWhenLocked.TabIndex = 8;
            chkDisableWhenLocked.Text = "Disable when station locked";
            chkDisableWhenLocked.UseVisualStyleBackColor = true;
            chkDisableWhenLocked.CheckedChanged += chkDisableWhenLocked_CheckedChanged;
            // 
            // chkDisablewithmonitor
            // 
            chkDisablewithmonitor.AutoSize = true;
            chkDisablewithmonitor.Location = new Point(19, 211);
            chkDisablewithmonitor.Margin = new Padding(6);
            chkDisablewithmonitor.Name = "chkDisablewithmonitor";
            chkDisablewithmonitor.Size = new Size(342, 36);
            chkDisablewithmonitor.TabIndex = 7;
            chkDisablewithmonitor.Text = "Disable when monitor(s) off";
            chkDisablewithmonitor.UseVisualStyleBackColor = true;
            chkDisablewithmonitor.CheckedChanged += chkDisablewithmonitor_CheckedChanged;
            // 
            // chkDisableDetection
            // 
            chkDisableDetection.AutoSize = true;
            chkDisableDetection.Location = new Point(19, 158);
            chkDisableDetection.Margin = new Padding(6);
            chkDisableDetection.Name = "chkDisableDetection";
            chkDisableDetection.Size = new Size(311, 36);
            chkDisableDetection.TabIndex = 6;
            chkDisableDetection.Text = "Disable Sound Detection";
            chkDisableDetection.UseVisualStyleBackColor = true;
            chkDisableDetection.CheckedChanged += chkDisableDetection_CheckedChanged;
            // 
            // cbDevices
            // 
            cbDevices.FormattingEnabled = true;
            cbDevices.Location = new Point(19, 47);
            cbDevices.Margin = new Padding(6);
            cbDevices.Name = "cbDevices";
            cbDevices.Size = new Size(500, 40);
            cbDevices.TabIndex = 4;
            cbDevices.SelectedIndexChanged += cbDevices_SelectedIndexChanged;
            // 
            // tmrLevelIndicator
            // 
            tmrLevelIndicator.Tick += tmrLevelIndicator_Tick;
            // 
            // cbTrayIcon
            // 
            cbTrayIcon.FormattingEnabled = true;
            cbTrayIcon.Items.AddRange(new object[] { "Black Outline", "Black Solid", "White Outline", "White Solid" });
            cbTrayIcon.Location = new Point(209, 301);
            cbTrayIcon.Margin = new Padding(6);
            cbTrayIcon.Name = "cbTrayIcon";
            cbTrayIcon.Size = new Size(333, 40);
            cbTrayIcon.TabIndex = 3;
            cbTrayIcon.SelectedIndexChanged += cbTrayIcon_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 301);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 0;
            label2.Text = "Tray Icon Style";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 459);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(196, 32);
            label4.TabIndex = 0;
            label4.Text = "Sample Rate (Hz)";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbSampleRate
            // 
            cbSampleRate.FormattingEnabled = true;
            cbSampleRate.Items.AddRange(new object[] { "44100", "48000" });
            cbSampleRate.Location = new Point(239, 459);
            cbSampleRate.Margin = new Padding(6);
            cbSampleRate.MaxDropDownItems = 2;
            cbSampleRate.Name = "cbSampleRate";
            cbSampleRate.Size = new Size(303, 40);
            cbSampleRate.TabIndex = 5;
            cbSampleRate.SelectedIndexChanged += cbSampleRate_SelectedIndexChanged;
            // 
            // chkStartup
            // 
            chkStartup.AutoSize = true;
            chkStartup.Location = new Point(39, 253);
            chkStartup.Margin = new Padding(6);
            chkStartup.Name = "chkStartup";
            chkStartup.Size = new Size(250, 36);
            chkStartup.TabIndex = 13;
            chkStartup.Text = "Start with Windows";
            chkStartup.UseVisualStyleBackColor = true;
            chkStartup.CheckedChanged += chkStartup_CheckedChanged;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 1092);
            Controls.Add(chkStartup);
            Controls.Add(label4);
            Controls.Add(cbSampleRate);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(cbTrayIcon);
            Controls.Add(groupBox1);
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            FormClosing += FrmSettings_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbOutputDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbOutputFreq).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbOutputBoost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrRefresh;
        private Label label1;
        private Label lblLastSound;
        private Button btnTest;
        private Label lblLastPlayed;
        private Label label3;
        private GroupBox groupBox1;
        private ProgressBar pbLevel;
        private GroupBox groupBox2;
        private ComboBox cbDevices;
        private Label lblInterval;
        private TrackBar tbInterval;
        private CheckBox chkDisableDetection;
        private System.Windows.Forms.Timer tmrLevelIndicator;
        private CheckBox chkDisablewithmonitor;
        private CheckBox chkDisableWhenLocked;
        private Label label4;
        private Label label5;
        private TrackBar tbOutputFreq;
        private Label label7;
        private TrackBar tbOutputBoost;
        private Label label8;
        private Label label9;
        private TrackBar tbOutputDuration;
        private Label label6;
        private TrackBar trackBar2;
        private ComboBox cbTrayIcon;
        private Label label2;
        private ComboBox cbSampleRate;
        private Label lblDuration;
        private CheckBox chkStartup;
    }
}