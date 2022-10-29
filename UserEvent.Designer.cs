namespace Stadium
{
    partial class UserEvent
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
            this.lbl_searchbyname = new System.Windows.Forms.Label();
            this.txt_srcname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_eventid = new System.Windows.Forms.Label();
            this.lbl_eventname = new System.Windows.Forms.Label();
            this.lbl_eventdate = new System.Windows.Forms.Label();
            this.lbl_eventtime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_reserve = new System.Windows.Forms.Button();
            this.btn_displayall = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_daysleft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_searchbyname
            // 
            this.lbl_searchbyname.AutoSize = true;
            this.lbl_searchbyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchbyname.Location = new System.Drawing.Point(24, 41);
            this.lbl_searchbyname.Name = "lbl_searchbyname";
            this.lbl_searchbyname.Size = new System.Drawing.Size(140, 20);
            this.lbl_searchbyname.TabIndex = 0;
            this.lbl_searchbyname.Text = "Search by Name";
            // 
            // txt_srcname
            // 
            this.txt_srcname.Location = new System.Drawing.Point(188, 41);
            this.txt_srcname.Name = "txt_srcname";
            this.txt_srcname.Size = new System.Drawing.Size(194, 20);
            this.txt_srcname.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 265);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // lbl_eventid
            // 
            this.lbl_eventid.AutoSize = true;
            this.lbl_eventid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventid.Location = new System.Drawing.Point(560, 146);
            this.lbl_eventid.Name = "lbl_eventid";
            this.lbl_eventid.Size = new System.Drawing.Size(56, 15);
            this.lbl_eventid.TabIndex = 4;
            this.lbl_eventid.Text = "EventID";
            // 
            // lbl_eventname
            // 
            this.lbl_eventname.AutoSize = true;
            this.lbl_eventname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventname.Location = new System.Drawing.Point(560, 177);
            this.lbl_eventname.Name = "lbl_eventname";
            this.lbl_eventname.Size = new System.Drawing.Size(84, 15);
            this.lbl_eventname.TabIndex = 5;
            this.lbl_eventname.Text = "Event Name";
            // 
            // lbl_eventdate
            // 
            this.lbl_eventdate.AutoSize = true;
            this.lbl_eventdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventdate.Location = new System.Drawing.Point(560, 215);
            this.lbl_eventdate.Name = "lbl_eventdate";
            this.lbl_eventdate.Size = new System.Drawing.Size(76, 15);
            this.lbl_eventdate.TabIndex = 6;
            this.lbl_eventdate.Text = "Event Date";
            // 
            // lbl_eventtime
            // 
            this.lbl_eventtime.AutoSize = true;
            this.lbl_eventtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventtime.Location = new System.Drawing.Point(560, 253);
            this.lbl_eventtime.Name = "lbl_eventtime";
            this.lbl_eventtime.Size = new System.Drawing.Size(78, 15);
            this.lbl_eventtime.TabIndex = 7;
            this.lbl_eventtime.Text = "Event Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(415, 35);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 32);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_reserve
            // 
            this.btn_reserve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserve.Location = new System.Drawing.Point(596, 308);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(172, 32);
            this.btn_reserve.TabIndex = 12;
            this.btn_reserve.Text = "Reserve a Ticket";
            this.btn_reserve.UseVisualStyleBackColor = true;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // btn_displayall
            // 
            this.btn_displayall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_displayall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_displayall.Location = new System.Drawing.Point(43, 400);
            this.btn_displayall.Name = "btn_displayall";
            this.btn_displayall.Size = new System.Drawing.Size(172, 32);
            this.btn_displayall.TabIndex = 13;
            this.btn_displayall.Text = "Display All";
            this.btn_displayall.UseVisualStyleBackColor = true;
            this.btn_displayall.Click += new System.EventHandler(this.btn_displayall_Click);
            // 
            // btn_count
            // 
            this.btn_count.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_count.Location = new System.Drawing.Point(267, 400);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(172, 32);
            this.btn_count.TabIndex = 14;
            this.btn_count.Text = "Count Events";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_daysleft
            // 
            this.btn_daysleft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_daysleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_daysleft.Location = new System.Drawing.Point(490, 400);
            this.btn_daysleft.Name = "btn_daysleft";
            this.btn_daysleft.Size = new System.Drawing.Size(172, 32);
            this.btn_daysleft.TabIndex = 15;
            this.btn_daysleft.Text = "Days Left";
            this.btn_daysleft.UseVisualStyleBackColor = true;
            this.btn_daysleft.Click += new System.EventHandler(this.btn_daysleft_Click);
            // 
            // UserEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(869, 609);
            this.Controls.Add(this.btn_daysleft);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.btn_displayall);
            this.Controls.Add(this.btn_reserve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_eventtime);
            this.Controls.Add(this.lbl_eventdate);
            this.Controls.Add(this.lbl_eventname);
            this.Controls.Add(this.lbl_eventid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_srcname);
            this.Controls.Add(this.lbl_searchbyname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserEvent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_searchbyname;
        private System.Windows.Forms.TextBox txt_srcname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_eventid;
        private System.Windows.Forms.Label lbl_eventname;
        private System.Windows.Forms.Label lbl_eventdate;
        private System.Windows.Forms.Label lbl_eventtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_reserve;
        private System.Windows.Forms.Button btn_displayall;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button btn_daysleft;
    }
}