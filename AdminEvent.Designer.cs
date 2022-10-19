namespace Stadium
{
    partial class AdminEvent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_srchname = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_eventtime = new System.Windows.Forms.TextBox();
            this.txt_eventname = new System.Windows.Forms.TextBox();
            this.lbl_eventtime = new System.Windows.Forms.Label();
            this.lbl_eventdate = new System.Windows.Forms.Label();
            this.lbl_eventname = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_display = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_eventid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(487, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 186);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(854, 74);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(82, 31);
            this.btn_search.TabIndex = 29;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(876, 396);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(175, 30);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(695, 396);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(175, 30);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_srchname
            // 
            this.lbl_srchname.AutoSize = true;
            this.lbl_srchname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srchname.Location = new System.Drawing.Point(456, 86);
            this.lbl_srchname.Name = "lbl_srchname";
            this.lbl_srchname.Size = new System.Drawing.Size(168, 24);
            this.lbl_srchname.TabIndex = 25;
            this.lbl_srchname.Text = "Search by name/id";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(630, 76);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(201, 29);
            this.txt_search.TabIndex = 24;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // txt_eventtime
            // 
            this.txt_eventtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eventtime.Location = new System.Drawing.Point(194, 207);
            this.txt_eventtime.Name = "txt_eventtime";
            this.txt_eventtime.Size = new System.Drawing.Size(200, 29);
            this.txt_eventtime.TabIndex = 23;
            // 
            // txt_eventname
            // 
            this.txt_eventname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eventname.Location = new System.Drawing.Point(194, 126);
            this.txt_eventname.Name = "txt_eventname";
            this.txt_eventname.Size = new System.Drawing.Size(196, 29);
            this.txt_eventname.TabIndex = 21;
            // 
            // lbl_eventtime
            // 
            this.lbl_eventtime.AutoSize = true;
            this.lbl_eventtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventtime.Location = new System.Drawing.Point(39, 212);
            this.lbl_eventtime.Name = "lbl_eventtime";
            this.lbl_eventtime.Size = new System.Drawing.Size(106, 24);
            this.lbl_eventtime.TabIndex = 20;
            this.lbl_eventtime.Text = "Event Time";
            // 
            // lbl_eventdate
            // 
            this.lbl_eventdate.AutoSize = true;
            this.lbl_eventdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventdate.Location = new System.Drawing.Point(39, 172);
            this.lbl_eventdate.Name = "lbl_eventdate";
            this.lbl_eventdate.Size = new System.Drawing.Size(101, 24);
            this.lbl_eventdate.TabIndex = 19;
            this.lbl_eventdate.Text = "Event Date";
            // 
            // lbl_eventname
            // 
            this.lbl_eventname.AutoSize = true;
            this.lbl_eventname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventname.Location = new System.Drawing.Point(39, 131);
            this.lbl_eventname.Name = "lbl_eventname";
            this.lbl_eventname.Size = new System.Drawing.Size(114, 24);
            this.lbl_eventname.TabIndex = 18;
            this.lbl_eventname.Text = "Event Name";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(119, 305);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(175, 30);
            this.btn_add.TabIndex = 33;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_display
            // 
            this.btn_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.Location = new System.Drawing.Point(514, 396);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(175, 30);
            this.btn_display.TabIndex = 35;
            this.btn_display.Text = "Display all";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Event ID";
            // 
            // txt_eventid
            // 
            this.txt_eventid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eventid.Location = new System.Drawing.Point(194, 83);
            this.txt_eventid.Name = "txt_eventid";
            this.txt_eventid.ReadOnly = true;
            this.txt_eventid.Size = new System.Drawing.Size(196, 29);
            this.txt_eventid.TabIndex = 37;
            // 
            // AdminEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1121, 504);
            this.Controls.Add(this.txt_eventid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_srchname);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_eventtime);
            this.Controls.Add(this.txt_eventname);
            this.Controls.Add(this.lbl_eventtime);
            this.Controls.Add(this.lbl_eventdate);
            this.Controls.Add(this.lbl_eventname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEvent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_srchname;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_eventtime;
        private System.Windows.Forms.TextBox txt_eventname;
        private System.Windows.Forms.Label lbl_eventtime;
        private System.Windows.Forms.Label lbl_eventdate;
        private System.Windows.Forms.Label lbl_eventname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.TextBox txt_eventid;
        private System.Windows.Forms.Label label1;
    }
}