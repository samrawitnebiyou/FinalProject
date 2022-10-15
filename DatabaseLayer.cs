using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stadium
{
     class DatabaseLayer
    {
        string path = @"Data Source=DESKTOP-CIN4PJD\MSSQLSERVERS;Database=stadiumdatabsefinal;Integrated security = true";
        public void CreateUser(User u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spCreateUser", con);
                    cmd.CommandType =System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", u.id);
                    cmd.Parameters.AddWithValue("@email", u.email);
                    cmd.Parameters.AddWithValue("@userName", u.userName);
                    cmd.Parameters.AddWithValue("@password", u.password);
                    cmd.Parameters.AddWithValue("@firstName", u.fname);
                    cmd.Parameters.AddWithValue("@lastName", u.lname);
                    cmd.Parameters.AddWithValue("@photo", u.photo);

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Account created succesfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
