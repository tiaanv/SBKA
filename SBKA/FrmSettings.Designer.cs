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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Last Sound Detected";
            // 
            // lblLastSound
            // 
            lblLastSound.AutoSize = true;
            lblLastSound.Location = new Point(176, 9);
            lblLastSound.Name = "lblLastSound";
            lblLastSound.Size = new Size(29, 15);
            lblLastSound.TabIndex = 1;
            lblLastSound.Text = "N/A";
            // 
            // btnTest
            // 
            btnTest.Location = new Point(266, 71);
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
            lblLastPlayed.Location = new Point(176, 36);
            lblLastPlayed.Name = "lblLastPlayed";
            lblLastPlayed.Size = new Size(29, 15);
            lblLastPlayed.TabIndex = 4;
            lblLastPlayed.Text = "N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 36);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 3;
            label3.Text = "Last Sound Played";
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 106);
            Controls.Add(lblLastPlayed);
            Controls.Add(label3);
            Controls.Add(btnTest);
            Controls.Add(lblLastSound);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
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
    }
}