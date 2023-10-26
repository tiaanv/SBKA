namespace SBKA
{
    partial class FrmSettings
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
            lblInterval = new Label();
            label2 = new Label();
            tbInterval = new TrackBar();
            chkDisableDetection = new CheckBox();
            cbDevices = new ComboBox();
            tmrLevelIndicator = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbInterval).BeginInit();
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
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Last Sound Detected";
            // 
            // lblLastSound
            // 
            lblLastSound.AutoSize = true;
            lblLastSound.Location = new Point(170, 19);
            lblLastSound.Name = "lblLastSound";
            lblLastSound.Size = new Size(29, 15);
            lblLastSound.TabIndex = 1;
            lblLastSound.Text = "N/A";
            // 
            // btnTest
            // 
            btnTest.Location = new Point(205, 67);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 2;
            btnTest.Text = "TEST";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // lblLastPlayed
            // 
            lblLastPlayed.AutoSize = true;
            lblLastPlayed.Location = new Point(170, 46);
            lblLastPlayed.Name = "lblLastPlayed";
            lblLastPlayed.Size = new Size(29, 15);
            lblLastPlayed.TabIndex = 4;
            lblLastPlayed.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 46);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 101);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detection && Test";
            // 
            // pbLevel
            // 
            pbLevel.Location = new Point(9, 74);
            pbLevel.Name = "pbLevel";
            pbLevel.Size = new Size(158, 10);
            pbLevel.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblInterval);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tbInterval);
            groupBox2.Controls.Add(chkDisableDetection);
            groupBox2.Controls.Add(cbDevices);
            groupBox2.Location = new Point(11, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 130);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Audio Device";
            // 
            // lblInterval
            // 
            lblInterval.AutoSize = true;
            lblInterval.Location = new Point(102, 79);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(66, 15);
            lblInterval.TabIndex = 9;
            lblInterval.Text = "10 Seconds";
            lblInterval.Click += lblInterval_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 79);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 8;
            label2.Text = "Interval";
            // 
            // tbInterval
            // 
            tbInterval.Location = new Point(10, 97);
            tbInterval.Maximum = 600;
            tbInterval.Minimum = 1;
            tbInterval.Name = "tbInterval";
            tbInterval.Size = new Size(271, 45);
            tbInterval.TabIndex = 7;
            tbInterval.TickFrequency = 30;
            tbInterval.Value = 1;
            tbInterval.ValueChanged += tbInterval_ValueChanged;
            // 
            // chkDisableDetection
            // 
            chkDisableDetection.AutoSize = true;
            chkDisableDetection.Location = new Point(10, 51);
            chkDisableDetection.Name = "chkDisableDetection";
            chkDisableDetection.Size = new Size(155, 19);
            chkDisableDetection.TabIndex = 1;
            chkDisableDetection.Text = "Disable Sound Detection";
            chkDisableDetection.UseVisualStyleBackColor = true;
            chkDisableDetection.CheckedChanged += chkDisableDetection_CheckedChanged;
            // 
            // cbDevices
            // 
            cbDevices.FormattingEnabled = true;
            cbDevices.Location = new Point(10, 22);
            cbDevices.Name = "cbDevices";
            cbDevices.Size = new Size(271, 23);
            cbDevices.TabIndex = 0;
            cbDevices.SelectedIndexChanged += cbDevices_SelectedIndexChanged;
            // 
            // tmrLevelIndicator
            // 
            tmrLevelIndicator.Tick += tmrLevelIndicator_Tick;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 257);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            ResumeLayout(false);
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
        private Label label2;
        private TrackBar tbInterval;
        private CheckBox chkDisableDetection;
        private System.Windows.Forms.Timer tmrLevelIndicator;
    }
}