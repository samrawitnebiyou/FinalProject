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
            bool isVal = true;
            //This regular expression refers to a pattern which accepts 5 to 15 characters with any lower case character, digit or special symbol “_-” only.
            Regex username = new Regex(@"^[a-z0-9_-]{5,15}$");

            //This regular expression refers to a pattern with at least one digit, one upper case letter, one lower case letter and one special symbol(“@#$%”).
            Regex pass = new Regex(@"^((?=.*\d)(?=.*[A-Za - z])(?=.*[A - Z])(?=.*[@#$%]).{6,15})$");

            //Email Format(name@example.com)
            Regex email = new Regex(@"^[_A-Za-z0-9-\+]+(\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9]+)*(\.[A-Za-z]{2,})$");

            if (!username.IsMatch(txt_username.Text.ToLower()))
            {
                errorProvider1.SetError(txt_username, "Invalid! 5 to 15 charachterz (allowed - and _");
                isVal = false;

            }
            else
            {
                errorProvider1.Clear();
            }
            if (!pass.IsMatch(txt_password.Text))
            {
                errorProvider4.SetError(txt_password, "Invalid! needed at least one digit, one upper case letter, one lower case letter and one special symbol(“@#$%”)");
                isVal = false;

            }
            else
            {
                errorProvider4.Clear();
            }
            if (!email.IsMatch(txt_email.Text))
            {
                errorProvider1.SetError(txt_email, "Invalid! Format must be like name@example.com");
                isVal = false;

            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txt_fname.Text))
            {
                errorProvider2.SetError(txt_fname, "Invalid! First Name cannot be empty");
                isVal = false;
            }
            else
            {
                errorProvider2.Clear();
            }
            if (string.IsNullOrEmpty(txt_lname.Text))
            {
                errorProvider2.SetError(txt_lname, "Invalid! Last Name cannot be empty!");
                isVal = false;
            }
            else
            {
                errorProvider2.Clear();
            }
            if (!(txt_password.Text == txt_confirm.Text))
            {
                errorProvider3.SetError(txt_confirm, "Invalid! write your password correctly");
                isVal = false;
            }
            else
            {
                errorProvider3.Clear();
            }

            if (isVal)
            {
                User u = new User(txt_fname.Text, txt_lname.Text, txt_confirm.Text, txt_email.Text, txt_username.Text, txt_password.Text, photo);
                u.createUser();
                LoginForm l = new LoginForm();
                l.Show();
                this.Visible = false;
            }
        }

        

        private void txt_confirm_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
