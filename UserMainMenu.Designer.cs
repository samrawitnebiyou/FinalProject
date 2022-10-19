namespace Stadium
{
    partial class UserMainMenu
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_aboutus = new System.Windows.Forms.Button();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.btn_event = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.pbox_admin = new System.Windows.Forms.PictureBox();
            this.lbl_title_text = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(91, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(709, 378);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.lbl_title_text);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(91, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 72);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_aboutus);
            this.panel1.Controls.Add(this.btn_reservation);
            this.panel1.Controls.Add(this.btn_event);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.pbox_admin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 450);
            this.panel1.TabIndex = 3;
            // 
            // btn_aboutus
            // 
            this.btn_aboutus.Location = new System.Drawing.Point(10, 222);
            this.btn_aboutus.Name = "btn_aboutus";
            this.btn_aboutus.Size = new System.Drawing.Size(75, 23);
            this.btn_aboutus.TabIndex = 14;
            this.btn_aboutus.Text = "About Us";
            this.btn_aboutus.UseVisualStyleBackColor = true;
            // 
            // btn_reservation
            // 
            this.btn_reservation.Location = new System.Drawing.Point(10, 185);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(75, 22);
            this.btn_reservation.TabIndex = 13;
            this.btn_reservation.Text = "Reservation";
            this.btn_reservation.UseVisualStyleBackColor = true;
            // 
            // btn_event
            // 
            this.btn_event.Location = new System.Drawing.Point(10, 144);
            this.btn_event.Name = "btn_event";
            this.btn_event.Size = new System.Drawing.Size(75, 23);
            this.btn_event.TabIndex = 12;
            this.btn_event.Text = "Event";
            this.btn_event.UseVisualStyleBackColor = true;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(10, 104);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 11;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pbox_admin
            // 
            this.pbox_admin.Image = global::Stadium.Properties.Resources.icons8_user_96;
            this.pbox_admin.Location = new System.Drawing.Point(0, 0);
            this.pbox_admin.Name = "pbox_admin";
            this.pbox_admin.Size = new System.Drawing.Size(91, 75);
            this.pbox_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_admin.TabIndex = 10;
            this.pbox_admin.TabStop = false;
            // 
            // lbl_title_text
            // 
            this.lbl_title_text.AutoSize = true;
            this.lbl_title_text.Location = new System.Drawing.Point(49, 31);
            this.lbl_title_text.Name = "lbl_title_text";
            this.lbl_title_text.Size = new System.Drawing.Size(35, 13);
            this.lbl_title_text.TabIndex = 1;
            this.lbl_title_text.Text = "label1";
            // 
            // UserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserMainMenu";
            this.Text = "UserMainMenu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_aboutus;
        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.Button btn_event;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.PictureBox pbox_admin;
        private System.Windows.Forms.Label lbl_title_text;
    }
}