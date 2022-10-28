using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium
{
    public partial class AdminTicket : Form
    {
        public AdminTicket()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool isVal = true;
           
            try
            {

                double.Parse(txt_amount.Text);
                errorProvider2.Clear();

            }
            catch (Exception)
            {

                errorProvider2.SetError(txt_amount, "Invalid Amount!");
                isVal = false;
            }
            if(!(rbtn_regular.Checked || rbtn_vip.Checked))
            {
                errorProvider3.SetError(rbtn_vip, "Select one!");
                isVal = false;

            }
            else
            {
                errorProvider3.Clear();
            }
           

            if (isVal)
            {
                DatabaseLayer db = new DatabaseLayer();
                string type;
                if (rbtn_regular.Checked)
                {
                    type = "Regular";
                }
                else
                {
                    type = "VIP";
                }
                Ticket t = new Ticket(type, txt_amount.Text, txt_eventname.Text);
                db.InsertTicket(t);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool isVal = true;
            string str = txt_tkttype.Text.ToLower();
            if (str!="vip")
            {
                errorProvider4.SetError(txt_tkttype, "Please write 'vip' or 'regular'");
                isVal = false;
            }
            else
            {
                errorProvider4.Clear();
            }
            if (isVal)
            {
                DatabaseLayer db = new DatabaseLayer();

                dataGridView1.DataSource = db.TicketbyType(txt_tkttype.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseLayer db = new DatabaseLayer();
            dataGridView1.DataSource = db.DisplayTicket();
        }

       

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_ticketid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (a == "Regular")
            {
                rbtn_regular.Checked=true;
            }
            else
            {
                rbtn_vip.Checked = true;
            }
            txt_amount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_eventname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DatabaseLayer db = new DatabaseLayer();
            Ticket t = new Ticket(int.Parse(txt_ticketid.Text));
            db.DeleteTicket(t);
            txt_ticketid.Clear();
            txt_tkttype.Clear();
            txt_amount.Clear();
            txt_eventname.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string type = "";
            if (rbtn_regular.Checked)
            {
                type = "Regular";
            }
            else
            {
                type = "VIP";
            }
            DatabaseLayer db = new DatabaseLayer();
            Ticket t = new Ticket(int.Parse(txt_ticketid.Text), type, txt_amount.Text, txt_eventname.Text);
            db.UpdateTicket(t);
            txt_ticketid.Clear();
            txt_tkttype.Clear();
            txt_amount.Clear();
            txt_eventname.Clear();
        }
    }
}
