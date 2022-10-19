namespace Stadium
{
    partial class Home
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
            this.lbl_home = new System.Windows.Forms.Label();
            this.pbox_ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ball)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_home
            // 
            this.lbl_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.Location = new System.Drawing.Point(20, 293);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(816, 55);
            this.lbl_home.TabIndex = 2;
            this.lbl_home.Text = "Stadium Ticket Reservation System";
            // 
            // pbox_ball
            // 
            this.pbox_ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbox_ball.Image = global::Stadium.Properties.Resources.pngegg;
            this.pbox_ball.Location = new System.Drawing.Point(329, 97);
            this.pbox_ball.Name = "pbox_ball";
            this.pbox_ball.Size = new System.Drawing.Size(152, 148);
            this.pbox_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_ball.TabIndex = 3;
            this.pbox_ball.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(844, 491);
            this.Controls.Add(this.pbox_ball);
            this.Controls.Add(this.lbl_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_ball;
        private System.Windows.Forms.Label lbl_home;
    }
}