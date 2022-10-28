using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadium
{
    class Login
    {
        public string getRole(string uname, string pwd)
        {
            DatabaseLayer udbl = new DatabaseLayer();
            string role = udbl.getRole(uname, pwd);
            return role;
        }
    }
}
