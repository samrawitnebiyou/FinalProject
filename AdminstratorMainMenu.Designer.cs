namespace Stadium
{
    partial class AdminstratorMainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_members = new System.Windows.Forms.Button();
            this.btn_ticket = new System.Windows.Forms.Button();
            this.btn_event = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title_text = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbox_admin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_members);
            this.panel1.Controls.Add(this.btn_ticket);
            this.panel1.Controls.Add(this.btn_event);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.pbox_admin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 514);
            this.panel1.TabIndex = 0;
            // 
            // btn_members
            // 
            this.btn_members.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_members.Location = new System.Drawing.Point(3, 317);
            this.btn_members.Name = "btn_members";
            this.btn_members.Size = new System.Drawing.Size(82, 23);
            this.btn_members.TabIndex = 9;
            this.btn_members.Text = "Member";
            this.btn_members.UseCompatibleTextRendering = true;
            this.btn_members.UseVisualStyleBackColor = true;
            this.btn_members.Click += new System.EventHandler(this.btn_members_Click);
            // 
            // btn_ticket
            // 
            this.btn_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ticket.Location = new System.Drawing.Point(3, 255);
            this.btn_ticket.Name = "btn_ticket";
            this.btn_ticket.Size = new System.Drawing.Size(82, 22);
            this.btn_ticket.TabIndex = 8;
            this.btn_ticket.Text = "Ticket";
            this.btn_ticket.UseCompatibleTextRendering = true;
            this.btn_ticket.UseVisualStyleBackColor = true;
            this.btn_ticket.Click += new System.EventHandler(this.btn_ticket_Click);
            // 
            // btn_event
            // 
            this.btn_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_event.Location = new System.Drawing.Point(3, 193);
            this.btn_event.Name = "btn_event";
            this.btn_event.Size = new System.Drawing.Size(82, 23);
            this.btn_event.TabIndex = 7;
            this.btn_event.Text = "Event";
            this.btn_event.UseCompatibleTextRendering = true;
            this.btn_event.UseVisualStyleBackColor = true;
            this.btn_event.Click += new System.EventHandler(this.btn_event_Click);
            // 
            // btn_home
            // 
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(3, 128);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(82, 23);
            this.btn_home.TabIndex = 6;
            this.btn_home.Text = "Home";
            this.btn_home.UseCompatibleTextRendering = true;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.lbl_title_text);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(91, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 78);
            this.panel2.TabIndex = 1;
            // 
            // lbl_title_text
            // 
            this.lbl_title_text.AutoSize = true;
            this.lbl_title_text.Location = new System.Drawing.Point(69, 25);
            this.lbl_title_text.Name = "lbl_title_text";
            this.lbl_title_text.Size = new System.Drawing.Size(35, 13);
            this.lbl_title_text.TabIndex = 0;
            this.lbl_title_text.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(91, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 436);
            this.panel3.TabIndex = 2;
            // 
            // pbox_admin
            // 
            this.pbox_admin.Image = global::Stadium.Properties.Resources.icons8_admin_settings_male_96;
            this.pbox_admin.Location = new System.Drawing.Point(0, 3);
            this.pbox_admin.Name = "pbox_admin";
            this.pbox_admin.Size = new System.Drawing.Size(91, 75);
            this.pbox_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_admin.TabIndex = 5;
            this.pbox_admin.TabStop = false;
            this.pbox_admin.Click += new System.EventHandler(this.pbox_admin_Click);
            // 
            // AdminstratorMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(966, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminstratorMainMenu";
            this.Text = "AdminstratorMainMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_members;
        private System.Windows.Forms.Button btn_ticket;
        private System.Windows.Forms.Button btn_event;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.PictureBox pbox_admin;
        private System.Windows.Forms.Label lbl_title_text;
    }
}