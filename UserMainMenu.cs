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
    public partial class UserMainMenu : Form
    {
        public UserMainMenu()
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

        private void btn_event_Click(object sender, EventArgs e)
        {
            UserEvent ue = new UserEvent();
            ue.TopLevel = false;
            ue.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(ue);
            lbl_title_text.Text = ue.Text;
            ue.BringToFront();
            ue.Show();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {

            UserReservation ue = new UserReservation();
            ue.TopLevel = false;
            ue.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(ue);
            lbl_title_text.Text = ue.Text;
            ue.BringToFront();
            ue.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();

            lf.Show();
            this.Close();

        }

        private void btn_aboutus_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.TopLevel = false;
            au.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(au);
            lbl_title_text.Text = au.Text;
            au.BringToFront();
            au.Show();

        }
    }
}
