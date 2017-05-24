namespace VSPROEKT
{
    partial class LoserWinner
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
            this.pbLoserWinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoserWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLoserWinner
            // 
            this.pbLoserWinner.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbLoserWinner.Location = new System.Drawing.Point(0, 0);
            this.pbLoserWinner.Name = "pbLoserWinner";
            this.pbLoserWinner.Size = new System.Drawing.Size(460, 344);
            this.pbLoserWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoserWinner.TabIndex = 0;
            this.pbLoserWinner.TabStop = false;
            // 
            // LoserWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 345);
            this.Controls.Add(this.pbLoserWinner);
            this.Name = "LoserWinner";
            this.Text = "Loser";
            this.Load += new System.EventHandler(this.Loser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoserWinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoserWinner;
    }
}