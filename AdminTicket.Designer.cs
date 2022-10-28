namespace Stadium
{
    partial class AdminTicket
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
            this.txt_ticketid = new System.Windows.Forms.TextBox();
            this.lbl_ticketid = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_srchname = new System.Windows.Forms.Label();
            this.txt_tkttype = new System.Windows.Forms.TextBox();
            this.txt_eventname = new System.Windows.Forms.TextBox();
            this.lbl_eventname = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.rbtn_regular = new System.Windows.Forms.RadioButton();
            this.rbtn_vip = new System.Windows.Forms.RadioButton();
            this.gbox_tickettype = new System.Windows.Forms.GroupBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbox_tickettype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ticketid
            // 
            this.txt_ticketid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ticketid.Location = new System.Drawing.Point(217, 66);
            this.txt_ticketid.Name = "txt_ticketid";
            this.txt_ticketid.ReadOnly = true;
            this.txt_ticketid.Size = new System.Drawing.Size(196, 29);
            this.txt_ticketid.TabIndex = 51;
            // 
            // lbl_ticketid
            // 
            this.lbl_ticketid.AutoSize = true;
            this.lbl_ticketid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ticketid.Location = new System.Drawing.Point(118, 66);
            this.lbl_ticketid.Name = "lbl_ticketid";
            this.lbl_ticketid.Size = new System.Drawing.Size(82, 24);
            this.lbl_ticketid.TabIndex = 50;
            this.lbl_ticketid.Text = "Ticket ID";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(176, 415);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(237, 30);
            this.btn_add.TabIndex = 47;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(566, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 186);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // lbl_srchname
            // 
            this.lbl_srchname.AutoSize = true;
            this.lbl_srchname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srchname.Location = new System.Drawing.Point(505, 54);
            this.lbl_srchname.Name = "lbl_srchname";
            this.lbl_srchname.Size = new System.Drawing.Size(198, 24);
            this.lbl_srchname.TabIndex = 44;
            this.lbl_srchname.Text = "Search by Ticket Type";
            // 
            // txt_tkttype
            // 
            this.txt_tkttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tkttype.Location = new System.Drawing.Point(709, 54);
            this.txt_tkttype.Name = "txt_tkttype";
            this.txt_tkttype.Size = new System.Drawing.Size(201, 29);
            this.txt_tkttype.TabIndex = 43;
            // 
            // txt_eventname
            // 
            this.txt_eventname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eventname.Location = new System.Drawing.Point(244, 307);
            this.txt_eventname.Name = "txt_eventname";
            this.txt_eventname.Size = new System.Drawing.Size(200, 29);
            this.txt_eventname.TabIndex = 42;
            // 
            // lbl_eventname
            // 
            this.lbl_eventname.AutoSize = true;
            this.lbl_eventname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eventname.Location = new System.Drawing.Point(118, 312);
            this.lbl_eventname.Name = "lbl_eventname";
            this.lbl_eventname.Size = new System.Drawing.Size(114, 24);
            this.lbl_eventname.TabIndex = 40;
            this.lbl_eventname.Text = "Event Name";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(118, 251);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(76, 24);
            this.lbl_amount.TabIndex = 39;
            this.lbl_amount.Text = "Amount";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(605, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 30);
            this.button1.TabIndex = 54;
            this.button1.Text = "Display all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(967, 355);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(175, 30);
            this.btn_delete.TabIndex = 53;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(941, 52);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(82, 31);
            this.btn_search.TabIndex = 55;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rbtn_regular
            // 
            this.rbtn_regular.AutoSize = true;
            this.rbtn_regular.Location = new System.Drawing.Point(6, 35);
            this.rbtn_regular.Name = "rbtn_regular";
            this.rbtn_regular.Size = new System.Drawing.Size(94, 28);
            this.rbtn_regular.TabIndex = 56;
            this.rbtn_regular.TabStop = true;
            this.rbtn_regular.Text = "Regular";
            this.rbtn_regular.UseVisualStyleBackColor = true;
            // 
            // rbtn_vip
            // 
            this.rbtn_vip.AutoSize = true;
            this.rbtn_vip.Location = new System.Drawing.Point(122, 35);
            this.rbtn_vip.Name = "rbtn_vip";
            this.rbtn_vip.Size = new System.Drawing.Size(57, 28);
            this.rbtn_vip.TabIndex = 57;
            this.rbtn_vip.TabStop = true;
            this.rbtn_vip.Text = "VIP";
            this.rbtn_vip.UseVisualStyleBackColor = true;
            // 
            // gbox_tickettype
            // 
            this.gbox_tickettype.Controls.Add(this.rbtn_vip);
            this.gbox_tickettype.Controls.Add(this.rbtn_regular);
            this.gbox_tickettype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_tickettype.Location = new System.Drawing.Point(122, 118);
            this.gbox_tickettype.Name = "gbox_tickettype";
            this.gbox_tickettype.Size = new System.Drawing.Size(188, 115);
            this.gbox_tickettype.TabIndex = 58;
            this.gbox_tickettype.TabStop = false;
            this.gbox_tickettype.Text = "Ticket Type";
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(244, 248);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(196, 29);
            this.txt_amount.TabIndex = 59;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(786, 355);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(175, 30);
            this.btn_update.TabIndex = 60;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // AdminTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1317, 516);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.gbox_tickettype);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_ticketid);
            this.Controls.Add(this.lbl_ticketid);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_srchname);
            this.Controls.Add(this.txt_tkttype);
            this.Controls.Add(this.txt_eventname);
            this.Controls.Add(this.lbl_eventname);
            this.Controls.Add(this.lbl_amount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminTicket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbox_tickettype.ResumeLayout(false);
            this.gbox_tickettype.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ticketid;
        private System.Windows.Forms.Label lbl_ticketid;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_srchname;
        private System.Windows.Forms.TextBox txt_tkttype;
        private System.Windows.Forms.TextBox txt_eventname;
        private System.Windows.Forms.Label lbl_eventname;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.RadioButton rbtn_regular;
        private System.Windows.Forms.RadioButton rbtn_vip;
        private System.Windows.Forms.GroupBox gbox_tickettype;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}