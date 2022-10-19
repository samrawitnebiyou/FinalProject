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
    public partial class AdminEvent : Form
    {
        public AdminEvent()
        {
            InitializeComponent();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool isVal = true;
            Regex r = new Regex(@"(1[012]|[1-9]):[0-5][0-9](\s)?(?i)(am|pm)$");
            if (!r.IsMatch(txt_eventtime.Text))
            {
                errorProvider1.SetError(txt_eventtime, "Inavlid! 12 hours format");
                isVal = false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txt_eventname.Text))
            {
                errorProvider1.SetError(txt_eventname, "Inavlid! Cannot be empty");
                isVal = false;
            }
            else
            {
                errorProvider1.Clear();

            }
            if (isVal)
            {
                DatabaseLayer db = new DatabaseLayer();
                Event ev = new Event(0, txt_eventname.Text, dateTimePicker1.Text, txt_eventtime.Text);
                db.InsertEvent(ev);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        { 
         string str = txt_search.Text;
         bool isNumber = int.TryParse(str, out int n);//returns true
            if (isNumber)
            {

                DatabaseLayer db = new DatabaseLayer();
                DataTable dt = db.DisplayEventByID(str);
                dataGridView1.DataSource = dt;

            }
            else
            {
                DatabaseLayer db = new DatabaseLayer();
                DataTable dt = db.DisplayEventByName(str);
                dataGridView1.DataSource = dt;

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DatabaseLayer db = new DatabaseLayer();
            Event ev = new Event(int.Parse(txt_eventid.Text), txt_eventname.Text, dateTimePicker1.Text, txt_eventtime.Text);
            db.UpdateEvent(ev);
            txt_eventid.Clear();
            txt_eventname.Clear();
            txt_eventtime.Clear();

        }

       

        private void btn_display_Click(object sender, EventArgs e)
        {
            DatabaseLayer db = new DatabaseLayer();
            dataGridView1.DataSource = db.DisplayEvent();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_eventid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_eventname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_eventtime.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DatabaseLayer db = new DatabaseLayer();
            Event ev = new Event(int.Parse(txt_eventid.Text));
            db.DeleteEvent(ev);
            txt_eventid.Clear();
            txt_eventname.Clear();
            txt_eventtime.Clear();
            
        }
    }
}
