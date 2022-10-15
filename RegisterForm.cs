using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lbl_confirm_Click(object sender, EventArgs e)
        {
            string pwd = txt_password.Text;
            string cpwd = txt_confirm.Text;
            if (pwd.CompareTo(cpwd) != 0)
            {
                MessageBox.Show("doesn't match");
                txt_password.Text = "";
                txt_confirm.Text = "";
            }
            else
            {
                MessageBox.Show("match");
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "choose photo(*.jpg;*.png;*.jpeg;*.bmp;) | *.jpg;*.png;*.jpeg;*.bmp;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pbox_user.Image = Image.FromFile(op.FileName);
            }
        }

       
        

        private void btn_signup_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pbox_user.Image.Save(ms, pbox_user.Image.RawFormat);
            byte[] photo = ms.ToArray();
            User u = new User(txt_fname.Text, txt_lname.Text, txt_confirm.Text, txt_email.Text, txt_username.Text, txt_password.Text, photo);
            u.createUser();
            LoginForm l = new LoginForm();
            l.Show();
            this.Visible = false;
        }

        

        private void txt_confirm_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
