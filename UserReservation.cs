using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Stadium
{
    public partial class UserReservation : Form
    {
        public UserReservation()
        {
            InitializeComponent();
        }
        

        private void UserReservation_Load(object sender, EventArgs e)
        {
            DatabaseLayer db = new DatabaseLayer();
            DataTable dt2 = db.DisplayTicket();
            dgvTicket.DataSource = dt2;
            DataTable dt3 = db.DisplaySeat();
            dgvSeat.DataSource = dt3;
        }

        private void dgvReservation_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_resid.Text = dgvReservation.CurrentRow.Cells[0].Value.ToString();
            dt_resdate.Text = dgvReservation.CurrentRow.Cells[1].Value.ToString();
            txt_restime.Text = dgvReservation.CurrentRow.Cells[2].Value.ToString();
            txt_name.Text = dgvReservation.CurrentRow.Cells[4].Value.ToString();
            txt_ticketid.Text = dgvReservation.CurrentRow.Cells[5].Value.ToString();
            txt_payamount.Text = dgvReservation.CurrentRow.Cells[6].Value.ToString();
            txt_tickettype.Text = dgvReservation.CurrentRow.Cells[7].Value.ToString();
            txt_eventname.Text = dgvReservation.CurrentRow.Cells[8].Value.ToString();
            txt_seatnumber.Text = dgvReservation.CurrentRow.Cells[9].Value.ToString();
            txt_seattype.Text = dgvReservation.CurrentRow.Cells[10].Value.ToString();
        }

        private void dgvTicket_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_ticketid.Text = dgvTicket.CurrentRow.Cells[0].Value.ToString();
            txt_payamount.Text = dgvTicket.CurrentRow.Cells[2].Value.ToString();
            txt_tickettype.Text = dgvTicket.CurrentRow.Cells[1].Value.ToString();
            txt_eventname.Text = dgvTicket.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvSeat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_seatnumber.Text = dgvSeat.CurrentRow.Cells[0].Value.ToString();
            txt_seattype.Text = dgvSeat.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DatabaseLayer db = new DatabaseLayer();
            DataTable dt1 = db.DisplayUserreservation(int.Parse(txt_srcname.Text));
            dgvReservation.DataSource = dt1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool isVal = true;
            Regex re = new Regex(@"(1[012]|[1-9]):[0-5][0-9](\s)?(?i)(am|pm)$");
            if (!re.IsMatch(txt_restime.Text))
            {
                errorProvider1.SetError(txt_restime, "Invalid Format");
                isVal = false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (isVal)
            {
                Reservation r = new Reservation(dt_resdate.Text, txt_restime.Text, txt_name.Text, int.Parse(txt_ticketid.Text));
                DatabaseLayer db = new DatabaseLayer();
                db.InsertReservationUpdateSeat(r, int.Parse(txt_seatnumber.Text));
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DatabaseLayer db = new DatabaseLayer();
            Reservation r = new Reservation(int.Parse(txt_resid.Text),dt_resdate.Text, txt_restime.Text, txt_name.Text, int.Parse(txt_ticketid.Text));
            db.UpdateReservation(r);

        }

        
        

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DatabaseLayer db = new DatabaseLayer();
            Reservation r = new Reservation(int.Parse(txt_resid.Text));
            db.DeleteReservation(r);
        }
    }
    

}

