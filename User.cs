using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadium
{
    class User
    {
       
        public int id;
        public string fname;
        public string lname;
        public string userName;
        public string password;
        public string confirmpassword;
        public string email;      
        public byte[] photo;

        public User(string fname, string lname, string confirmpassword, string email, string username, string password, byte[] photo)
        {
            this.fname = fname;
            this.lname = lname;
            this.confirmpassword = confirmpassword;
            this.email = email;
            this.userName = username;
            this.password = password;
            this.photo = photo;
        }

        public void createUser()
        {
            DatabaseLayer dbl = new DatabaseLayer();
            dbl.CreateUser(this);
        }
    }
}
