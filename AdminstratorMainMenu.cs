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
    public partial class AdminstratorMainMenu : Form
    {
        public AdminstratorMainMenu()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(home);
            lbl_title_text.Text = home.Text;
            home.BringToFront();
            home.Show();
        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {
            AdminTicket at = new AdminTicket();
            at.TopLevel = false;
            at.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(at);
            lbl_title_text.Text = at.Text;
            at.BringToFront();
            at.Show();

        }

        private void btn_event_Click(object sender, EventArgs e)
        {
            AdminEvent ae = new AdminEvent();
            ae.TopLevel = false;
            ae.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(ae);
            lbl_title_text.Text = ae.Text;
            ae.BringToFront();
            ae.Show();
        }

        private void btn_members_Click(object sender, EventArgs e)
        {

        }

        private void pbox_admin_Click(object sender, EventArgs e)
        {

        }
    }
}
