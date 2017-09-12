namespace VSPROEKT
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHorizontalScrollValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSpinLasts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbHorizontalScrollValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSpinLasts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudSpeed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudTimerInterval);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spin Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "miliseconds";
            // 
            // tbHorizontalScrollValue
            // 
            this.tbHorizontalScrollValue.Location = new System.Drawing.Point(122, 130);
            this.tbHorizontalScrollValue.Name = "tbHorizontalScrollValue";
            this.tbHorizontalScrollValue.ReadOnly = true;
            this.tbHorizontalScrollValue.Size = new System.Drawing.Size(100, 20);
            this.tbHorizontalScrollValue.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "HorizontalScrollValue:";
            // 
            // tbSpinLasts
            // 
            this.tbSpinLasts.Location = new System.Drawing.Point(80, 93);
            this.tbSpinLasts.Name = "tbSpinLasts";
            this.tbSpinLasts.ReadOnly = true;
            this.tbSpinLasts.Size = new System.Drawing.Size(120, 20);
            this.tbSpinLasts.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Spin lasts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Speed rate:";
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(80, 54);
            this.nudSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.ReadOnly = true;
            this.nudSpeed.Size = new System.Drawing.Size(120, 20);
            this.nudSpeed.TabIndex = 4;
            this.nudSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Refresh rate:";
            // 
            // nudTimerInterval
            // 
            this.nudTimerInterval.Location = new System.Drawing.Point(80, 15);
            this.nudTimerInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimerInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimerInterval.Name = "nudTimerInterval";
            this.nudTimerInterval.ReadOnly = true;
            this.nudTimerInterval.Size = new System.Drawing.Size(120, 20);
            this.nudTimerInterval.TabIndex = 2;
            this.nudTimerInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 206);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown nudTimerInterval;
        public System.Windows.Forms.TextBox tbSpinLasts;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbHorizontalScrollValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}