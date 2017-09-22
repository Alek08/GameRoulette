namespace VSPROEKT
{
    partial class Play
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.panelToHideScroll = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelColorBet = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBetCoins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelToDisplatCurrentColor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlayerCoins = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 210);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(15, 240);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 23);
            this.btnSpin.TabIndex = 1;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // pbArrow
            // 
            this.pbArrow.Location = new System.Drawing.Point(375, 200);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(30, 50);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrow.TabIndex = 9;
            this.pbArrow.TabStop = false;
            // 
            // panelToHideScroll
            // 
            this.panelToHideScroll.Location = new System.Drawing.Point(12, 205);
            this.panelToHideScroll.Name = "panelToHideScroll";
            this.panelToHideScroll.Size = new System.Drawing.Size(750, 20);
            this.panelToHideScroll.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panelColorBet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbBetCoins);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panelToDisplatCurrentColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPlayerCoins);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPlayerName);
            this.groupBox1.Controls.Add(this.btnRed);
            this.groupBox1.Controls.Add(this.btnGreen);
            this.groupBox1.Controls.Add(this.btnBlack);
            this.groupBox1.Location = new System.Drawing.Point(116, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 178);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Current color:";
            // 
            // panelColorBet
            // 
            this.panelColorBet.BackColor = System.Drawing.Color.White;
            this.panelColorBet.Location = new System.Drawing.Point(88, 137);
            this.panelColorBet.Name = "panelColorBet";
            this.panelColorBet.Size = new System.Drawing.Size(70, 35);
            this.panelColorBet.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your color bet:";
            // 
            // tbBetCoins
            // 
            this.tbBetCoins.Location = new System.Drawing.Point(66, 41);
            this.tbBetCoins.Name = "tbBetCoins";
            this.tbBetCoins.Size = new System.Drawing.Size(100, 20);
            this.tbBetCoins.TabIndex = 9;
            this.tbBetCoins.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bet with:";
            // 
            // panelToDisplatCurrentColor
            // 
            this.panelToDisplatCurrentColor.BackColor = System.Drawing.Color.White;
            this.panelToDisplatCurrentColor.Location = new System.Drawing.Point(499, 15);
            this.panelToDisplatCurrentColor.Name = "panelToDisplatCurrentColor";
            this.panelToDisplatCurrentColor.Size = new System.Drawing.Size(130, 63);
            this.panelToDisplatCurrentColor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Coins:";
            // 
            // tbPlayerCoins
            // 
            this.tbPlayerCoins.Location = new System.Drawing.Point(219, 15);
            this.tbPlayerCoins.Name = "tbPlayerCoins";
            this.tbPlayerCoins.ReadOnly = true;
            this.tbPlayerCoins.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerCoins.TabIndex = 5;
            this.tbPlayerCoins.TextChanged += new System.EventHandler(this.tbPlayerCoins_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player:";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(57, 15);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.ReadOnly = true;
            this.tbPlayerName.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerName.TabIndex = 3;
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRed.Location = new System.Drawing.Point(273, 81);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(112, 43);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "X2";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            this.btnRed.Paint += new System.Windows.Forms.PaintEventHandler(this.btnRed_Paint);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGreen.Location = new System.Drawing.Point(145, 81);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(112, 43);
            this.btnGreen.TabIndex = 1;
            this.btnGreen.Text = "X14";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            this.btnGreen.Paint += new System.Windows.Forms.PaintEventHandler(this.btnGreen_Paint);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlack.Location = new System.Drawing.Point(6, 81);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(112, 43);
            this.btnBlack.TabIndex = 0;
            this.btnBlack.Text = "X2";
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            this.btnBlack.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBlack_Paint);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbArrow);
            this.Controls.Add(this.panelToHideScroll);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.panel1);
            this.Name = "Play";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Play_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbArrow;
        private System.Windows.Forms.Panel panelToHideScroll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlayerCoins;
        private System.Windows.Forms.Panel panelToDisplatCurrentColor;
        private System.Windows.Forms.TextBox tbBetCoins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelColorBet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

