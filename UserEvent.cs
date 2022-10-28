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
    public partial class UserEvent : Form
    {
        public UserEvent()
        {
            InitializeComponent();
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
           
           


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            DatabaseLayer db = new DatabaseLayer();
            DataTable dt = db.DisplayEventByName(txt_srcname.Text);
            dataGridView1.DataSource = dt;
        }
        
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_displayall_Click(object sender, EventArgs e)
        {
            DatabaseLayer db = new DatabaseLayer();
            dataGridView1.DataSource=db.DisplayAllEvents();
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            DatabaseLayer db = new DatabaseLayer();
           int count= db.CountEvents();
            MessageBox.Show("There are " + count+ " events you can book");

        }

        private void btn_daysleft_Click(object sender, EventArgs e)
        {
            string name= dataGridView1.CurrentRow.Cells[1].Value.ToString();
           // DatabaseLayer db = new DatabaseLayer();
          //  db.DaysLeft(name);
        }
    }
    }

