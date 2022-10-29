namespace Stadium
{
    partial class AdminCustomer
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
            this.lbl_allusers = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_CountUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_userspecific = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_CountAdminstrator = new System.Windows.Forms.Label();
            this.lbl_alladmin = new System.Windows.Forms.Label();
            this.lbl_eventname = new System.Windows.Forms.Label();
            this.txt_eventname = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_allusers
            // 
            this.lbl_allusers.AutoSize = true;
            this.lbl_allusers.BackColor = System.Drawing.Color.Gray;
            this.lbl_allusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_allusers.Location = new System.Drawing.Point(45, 0);
            this.lbl_allusers.Name = "lbl_allusers";
            this.lbl_allusers.Size = new System.Drawing.Size(107, 25);
            this.lbl_allusers.TabIndex = 0;
            this.lbl_allusers.Text = "All Users";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_CountUser);
            this.panel1.Controls.Add(this.lbl_allusers);
            this.panel1.Location = new System.Drawing.Point(60, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // lbl_CountUser
            // 
            this.lbl_CountUser.AutoSize = true;
            this.lbl_CountUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountUser.Location = new System.Drawing.Point(75, 63);
            this.lbl_CountUser.Name = "lbl_CountUser";
            this.lbl_CountUser.Size = new System.Drawing.Size(50, 16);
            this.lbl_CountUser.TabIndex = 1;
            this.lbl_CountUser.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_userspecific);
            this.panel2.Location = new System.Drawing.Point(427, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 74);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // lbl_userspecific
            // 
            this.lbl_userspecific.AutoSize = true;
            this.lbl_userspecific.BackColor = System.Drawing.Color.Gray;
            this.lbl_userspecific.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userspecific.Location = new System.Drawing.Point(3, 0);
            this.lbl_userspecific.Name = "lbl_userspecific";
            this.lbl_userspecific.Size = new System.Drawing.Size(283, 20);
            this.lbl_userspecific.TabIndex = 2;
            this.lbl_userspecific.Text = "Amount of users for specific event";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_CountAdminstrator);
            this.panel3.Controls.Add(this.lbl_alladmin);
            this.panel3.Location = new System.Drawing.Point(60, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 100);
            this.panel3.TabIndex = 3;
            // 
            // lbl_CountAdminstrator
            // 
            this.lbl_CountAdminstrator.AutoSize = true;
            this.lbl_CountAdminstrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountAdminstrator.Location = new System.Drawing.Point(113, 44);
            this.lbl_CountAdminstrator.Name = "lbl_CountAdminstrator";
            this.lbl_CountAdminstrator.Size = new System.Drawing.Size(50, 16);
            this.lbl_CountAdminstrator.TabIndex = 2;
            this.lbl_CountAdminstrator.Text = "label2";
            // 
            // lbl_alladmin
            // 
            this.lbl_alladmin.AutoSize = true;
            this.lbl_alladmin.BackColor = System.Drawing.Color.Gray;
            this.lbl_alladmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alladmin.Location = new System.Drawing.Point(57, 0);
            this.lbl_alladmin.Name = "lbl_alladmin";
            this.lbl_alladmin.Size = new System.Drawing.Size(191, 25);
            this.lbl_alladmin.TabIndex = 1;
            this.lbl_alladmin.Text = "All Adminstrators";
            // 
            // lbl_eventname
            // 
            this.lbl_eventname.AutoSize = true;
            this.lbl_eventname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventname.Location = new System.Drawing.Point(423, 59);
            this.lbl_eventname.Name = "lbl_eventname";
            this.lbl_eventname.Size = new System.Drawing.Size(155, 20);
            this.lbl_eventname.TabIndex = 4;
            this.lbl_eventname.Text = "Enter Event Name";
            // 
            // txt_eventname
            // 
            this.txt_eventname.Location = new System.Drawing.Point(584, 59);
            this.txt_eventname.Name = "txt_eventname";
            this.txt_eventname.Size = new System.Drawing.Size(129, 20);
            this.txt_eventname.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(719, 55);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 29);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // AdminCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(862, 491);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_eventname);
            this.Controls.Add(this.lbl_eventname);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCustomer";
            this.Load += new System.EventHandler(this.AdminCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_allusers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_CountUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_userspecific;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_CountAdminstrator;
        private System.Windows.Forms.Label lbl_alladmin;
        private System.Windows.Forms.Label lbl_eventname;
        private System.Windows.Forms.TextBox txt_eventname;
        private System.Windows.Forms.Button btn_search;
    }
}