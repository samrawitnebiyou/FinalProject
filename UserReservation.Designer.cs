namespace Stadium
{
    partial class UserReservation
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
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_srcname = new System.Windows.Forms.TextBox();
            this.lbl_searchbyname = new System.Windows.Forms.Label();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.dgvSeat = new System.Windows.Forms.DataGridView();
            this.lbl_rservationdate = new System.Windows.Forms.Label();
            this.lbl_reservationtime = new System.Windows.Forms.Label();
            this.lbl_ticketid = new System.Windows.Forms.Label();
            this.lbl_tickettype = new System.Windows.Forms.Label();
            this.lbl_payamount = new System.Windows.Forms.Label();
            this.lbl_eventname = new System.Windows.Forms.Label();
            this.lbl_seatno = new System.Windows.Forms.Label();
            this.lbl_seattype = new System.Windows.Forms.Label();
            this.txt_restime = new System.Windows.Forms.TextBox();
            this.txt_ticketid = new System.Windows.Forms.TextBox();
            this.txt_tickettype = new System.Windows.Forms.TextBox();
            this.txt_payamount = new System.Windows.Forms.TextBox();
            this.txt_eventname = new System.Windows.Forms.TextBox();
            this.txt_seatnumber = new System.Windows.Forms.TextBox();
            this.txt_seattype = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_reservationid = new System.Windows.Forms.Label();
            this.txt_resid = new System.Windows.Forms.TextBox();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dt_resdate = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(269, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 32);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_srcname
            // 
            this.txt_srcname.Location = new System.Drawing.Point(152, 33);
            this.txt_srcname.Name = "txt_srcname";
            this.txt_srcname.Size = new System.Drawing.Size(85, 20);
            this.txt_srcname.TabIndex = 4;
            // 
            // lbl_searchbyname
            // 
            this.lbl_searchbyname.AutoSize = true;
            this.lbl_searchbyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchbyname.Location = new System.Drawing.Point(6, 31);
            this.lbl_searchbyname.Name = "lbl_searchbyname";
            this.lbl_searchbyname.Size = new System.Drawing.Size(140, 20);
            this.lbl_searchbyname.TabIndex = 3;
            this.lbl_searchbyname.Text = "Search by Name";
            // 
            // dgvReservation
            // 
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Location = new System.Drawing.Point(12, 113);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.Size = new System.Drawing.Size(342, 191);
            this.dgvReservation.TabIndex = 6;
            this.dgvReservation.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReservation_RowHeaderMouseDoubleClick);
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(378, 113);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.Size = new System.Drawing.Size(342, 191);
            this.dgvTicket.TabIndex = 7;
            this.dgvTicket.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTicket_RowHeaderMouseDoubleClick);
            // 
            // dgvSeat
            // 
            this.dgvSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeat.Location = new System.Drawing.Point(768, 113);
            this.dgvSeat.Name = "dgvSeat";
            this.dgvSeat.Size = new System.Drawing.Size(342, 191);
            this.dgvSeat.TabIndex = 8;
            this.dgvSeat.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSeat_RowHeaderMouseDoubleClick);
            // 
            // lbl_rservationdate
            // 
            this.lbl_rservationdate.AutoSize = true;
            this.lbl_rservationdate.Location = new System.Drawing.Point(32, 391);
            this.lbl_rservationdate.Name = "lbl_rservationdate";
            this.lbl_rservationdate.Size = new System.Drawing.Size(90, 13);
            this.lbl_rservationdate.TabIndex = 9;
            this.lbl_rservationdate.Text = "Reservation Date";
            // 
            // lbl_reservationtime
            // 
            this.lbl_reservationtime.AutoSize = true;
            this.lbl_reservationtime.Location = new System.Drawing.Point(32, 425);
            this.lbl_reservationtime.Name = "lbl_reservationtime";
            this.lbl_reservationtime.Size = new System.Drawing.Size(90, 13);
            this.lbl_reservationtime.TabIndex = 10;
            this.lbl_reservationtime.Text = "Reservation Time";
            // 
            // lbl_ticketid
            // 
            this.lbl_ticketid.AutoSize = true;
            this.lbl_ticketid.Location = new System.Drawing.Point(280, 339);
            this.lbl_ticketid.Name = "lbl_ticketid";
            this.lbl_ticketid.Size = new System.Drawing.Size(51, 13);
            this.lbl_ticketid.TabIndex = 12;
            this.lbl_ticketid.Text = "Ticket ID";
            // 
            // lbl_tickettype
            // 
            this.lbl_tickettype.AutoSize = true;
            this.lbl_tickettype.Location = new System.Drawing.Point(280, 376);
            this.lbl_tickettype.Name = "lbl_tickettype";
            this.lbl_tickettype.Size = new System.Drawing.Size(64, 13);
            this.lbl_tickettype.TabIndex = 13;
            this.lbl_tickettype.Text = "Ticket Type";
            // 
            // lbl_payamount
            // 
            this.lbl_payamount.AutoSize = true;
            this.lbl_payamount.Location = new System.Drawing.Point(280, 401);
            this.lbl_payamount.Name = "lbl_payamount";
            this.lbl_payamount.Size = new System.Drawing.Size(87, 13);
            this.lbl_payamount.TabIndex = 14;
            this.lbl_payamount.Text = "Payment Amount";
            // 
            // lbl_eventname
            // 
            this.lbl_eventname.AutoSize = true;
            this.lbl_eventname.Location = new System.Drawing.Point(280, 438);
            this.lbl_eventname.Name = "lbl_eventname";
            this.lbl_eventname.Size = new System.Drawing.Size(66, 13);
            this.lbl_eventname.TabIndex = 15;
            this.lbl_eventname.Text = "Event Name";
            // 
            // lbl_seatno
            // 
            this.lbl_seatno.AutoSize = true;
            this.lbl_seatno.Location = new System.Drawing.Point(550, 332);
            this.lbl_seatno.Name = "lbl_seatno";
            this.lbl_seatno.Size = new System.Drawing.Size(69, 13);
            this.lbl_seatno.TabIndex = 16;
            this.lbl_seatno.Text = "Seat Number";
            // 
            // lbl_seattype
            // 
            this.lbl_seattype.AutoSize = true;
            this.lbl_seattype.Location = new System.Drawing.Point(550, 369);
            this.lbl_seattype.Name = "lbl_seattype";
            this.lbl_seattype.Size = new System.Drawing.Size(56, 13);
            this.lbl_seattype.TabIndex = 17;
            this.lbl_seattype.Text = "Seat Type";
            // 
            // txt_restime
            // 
            this.txt_restime.Location = new System.Drawing.Point(137, 425);
            this.txt_restime.Name = "txt_restime";
            this.txt_restime.Size = new System.Drawing.Size(100, 20);
            this.txt_restime.TabIndex = 19;
            // 
            // txt_ticketid
            // 
            this.txt_ticketid.Location = new System.Drawing.Point(378, 332);
            this.txt_ticketid.Name = "txt_ticketid";
            this.txt_ticketid.ReadOnly = true;
            this.txt_ticketid.Size = new System.Drawing.Size(100, 20);
            this.txt_ticketid.TabIndex = 21;
            // 
            // txt_tickettype
            // 
            this.txt_tickettype.Location = new System.Drawing.Point(378, 369);
            this.txt_tickettype.Name = "txt_tickettype";
            this.txt_tickettype.ReadOnly = true;
            this.txt_tickettype.Size = new System.Drawing.Size(100, 20);
            this.txt_tickettype.TabIndex = 22;
            // 
            // txt_payamount
            // 
            this.txt_payamount.Location = new System.Drawing.Point(378, 401);
            this.txt_payamount.Name = "txt_payamount";
            this.txt_payamount.ReadOnly = true;
            this.txt_payamount.Size = new System.Drawing.Size(100, 20);
            this.txt_payamount.TabIndex = 23;
            // 
            // txt_eventname
            // 
            this.txt_eventname.Location = new System.Drawing.Point(378, 435);
            this.txt_eventname.Name = "txt_eventname";
            this.txt_eventname.ReadOnly = true;
            this.txt_eventname.Size = new System.Drawing.Size(100, 20);
            this.txt_eventname.TabIndex = 24;
            // 
            // txt_seatnumber
            // 
            this.txt_seatnumber.Location = new System.Drawing.Point(620, 329);
            this.txt_seatnumber.Name = "txt_seatnumber";
            this.txt_seatnumber.ReadOnly = true;
            this.txt_seatnumber.Size = new System.Drawing.Size(100, 20);
            this.txt_seatnumber.TabIndex = 25;
            // 
            // txt_seattype
            // 
            this.txt_seattype.Location = new System.Drawing.Point(620, 366);
            this.txt_seattype.Name = "txt_seattype";
            this.txt_seattype.ReadOnly = true;
            this.txt_seattype.Size = new System.Drawing.Size(100, 20);
            this.txt_seattype.TabIndex = 26;
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(167, 532);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 33);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(312, 532);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 33);
            this.btn_update.TabIndex = 28;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(456, 532);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 33);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_reservationid
            // 
            this.lbl_reservationid.AutoSize = true;
            this.lbl_reservationid.Location = new System.Drawing.Point(32, 365);
            this.lbl_reservationid.Name = "lbl_reservationid";
            this.lbl_reservationid.Size = new System.Drawing.Size(78, 13);
            this.lbl_reservationid.TabIndex = 30;
            this.lbl_reservationid.Text = "Reservation ID";
            // 
            // txt_resid
            // 
            this.txt_resid.Location = new System.Drawing.Point(137, 362);
            this.txt_resid.Name = "txt_resid";
            this.txt_resid.ReadOnly = true;
            this.txt_resid.Size = new System.Drawing.Size(100, 20);
            this.txt_resid.TabIndex = 31;
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Location = new System.Drawing.Point(41, 463);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(54, 13);
            this.lbl_fullname.TabIndex = 32;
            this.lbl_fullname.Text = "Full Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(137, 460);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 33;
            // 
            // dt_resdate
            // 
            this.dt_resdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_resdate.Location = new System.Drawing.Point(134, 388);
            this.dt_resdate.Name = "dt_resdate";
            this.dt_resdate.Size = new System.Drawing.Size(103, 20);
            this.dt_resdate.TabIndex = 35;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1108, 628);
            this.Controls.Add(this.dt_resdate);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.txt_resid);
            this.Controls.Add(this.lbl_reservationid);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_seattype);
            this.Controls.Add(this.txt_seatnumber);
            this.Controls.Add(this.txt_eventname);
            this.Controls.Add(this.txt_payamount);
            this.Controls.Add(this.txt_tickettype);
            this.Controls.Add(this.txt_ticketid);
            this.Controls.Add(this.txt_restime);
            this.Controls.Add(this.lbl_seattype);
            this.Controls.Add(this.lbl_seatno);
            this.Controls.Add(this.lbl_eventname);
            this.Controls.Add(this.lbl_payamount);
            this.Controls.Add(this.lbl_tickettype);
            this.Controls.Add(this.lbl_ticketid);
            this.Controls.Add(this.lbl_reservationtime);
            this.Controls.Add(this.lbl_rservationdate);
            this.Controls.Add(this.dgvSeat);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.dgvReservation);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_srcname);
            this.Controls.Add(this.lbl_searchbyname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserReservation";
            this.Load += new System.EventHandler(this.UserReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_srcname;
        private System.Windows.Forms.Label lbl_searchbyname;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.DataGridView dgvSeat;
        private System.Windows.Forms.Label lbl_rservationdate;
        private System.Windows.Forms.Label lbl_reservationtime;
        private System.Windows.Forms.Label lbl_ticketid;
        private System.Windows.Forms.Label lbl_tickettype;
        private System.Windows.Forms.Label lbl_payamount;
        private System.Windows.Forms.Label lbl_eventname;
        private System.Windows.Forms.Label lbl_seatno;
        private System.Windows.Forms.Label lbl_seattype;
        private System.Windows.Forms.TextBox txt_restime;
        private System.Windows.Forms.TextBox txt_ticketid;
        private System.Windows.Forms.TextBox txt_tickettype;
        private System.Windows.Forms.TextBox txt_payamount;
        private System.Windows.Forms.TextBox txt_eventname;
        private System.Windows.Forms.TextBox txt_seatnumber;
        private System.Windows.Forms.TextBox txt_seattype;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_reservationid;
        private System.Windows.Forms.TextBox txt_resid;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DateTimePicker dt_resdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}