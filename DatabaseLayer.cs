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
          public string getRole(string un, string pwd)
        {
            string role = "";
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spGetRole", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userName", un);
                    cmd.Parameters.AddWithValue("@password", pwd);
                    object objRole = cmd.ExecuteScalar();
                    con.Close();
                    if (objRole != null)
                        role = objRole.ToString();
                    else
                        role = "No Role";

                    return role;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "ERROR";
            }
        }
        public void InsertEvent(Event e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertEvent", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", e.name);
                    cmd.Parameters.AddWithValue("@eventdate", e.date);
                    cmd.Parameters.AddWithValue("@eventtime", e.time);


                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Event Saved Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable DisplayEventByName(string name)
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {

                    da.SelectCommand = new SqlCommand("spGetEventbyName", con);
                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@eventName", name);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtEvent");

                    DataTable dt = ds.Tables["dtEvent"];
                    return dt;

                }
            }
        }
        public DataTable DisplayEventByID(string id)
        {
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {

                    da.SelectCommand = new SqlCommand("spGetEventbyID", con);
                    da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@eventid", id);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtEvent");

                    DataTable dt = ds.Tables["dtEvent"];
                    return dt;

                }
            }

        }
        public DataTable DisplayEvent()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDisplayEvent", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds, "dtEvent");
                    DataTable dt = ds.Tables["dtEvent"];
                    return dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void UpdateEvent(Event e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateEvent", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eventid", e.id);
                    cmd.Parameters.AddWithValue("@name", e.name);
                    cmd.Parameters.AddWithValue("@eventdate", e.date);
                    cmd.Parameters.AddWithValue("@eventtime", e.time);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Event Updated Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteEvent(Event e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteEvent", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eventid", e.id);

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Event Deleted Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertTicket(Ticket t)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertTicket", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@tickettype", t.tickettype);
                    cmd.Parameters.AddWithValue("@amount", t.amount);
                    cmd.Parameters.AddWithValue("@event", t.eventname);


                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Ticket Saved Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable TicketbyType(string name)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();


                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("TicketbyType", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@tickettype", name);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "dtTicket");

                        DataTable dt = ds.Tables["dtTicket"];
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }


        }
        public DataTable DisplayTicket()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDisplayTicket", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void UpdateTicket(Ticket t)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateTicket", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ticketid", t.ticketid);
                    cmd.Parameters.AddWithValue("@tickettype", t.tickettype);
                    cmd.Parameters.AddWithValue("@amount", t.amount);
                    cmd.Parameters.AddWithValue("@event", t.eventname);


                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Ticket updated Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteTicket(Ticket t)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteTicket", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ticketid", t.ticketid);

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Ticket Deleted Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string AllUsers()
        {
            string count = "";
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AllUsers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    object objCount = cmd.ExecuteScalar();
                    con.Close();
                    if (objCount != null)
                        count = objCount.ToString();
                    else
                        count = "No user";

                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "error";
            }
        }
        public string AllAdminstrator()
        {
            string count = "";
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AllAdminstrator", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    object objCount = cmd.ExecuteScalar();
                    con.Close();
                    if (objCount != null)
                        count = objCount.ToString();
                    else
                        count = "No user";

                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "error";
            }
        }
        public string UsersbyEvent(string name)
        {
            string count = "";
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UserbyEvent", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eventName", name);
                    object objCount = cmd.ExecuteScalar();
                    con.Close();
                    if (objCount != null)
                        count = objCount.ToString();
                    else
                        count = "No user";

                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "error";
            }
        }

        public DataTable DisplaySeat()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDisplaySeat", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable DisplayUserreservation(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();


                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spDisplayUserreservation", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@userID", id);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "dtReservation");

                        DataTable dt = ds.Tables["dtReservation"];
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }


        }

        public void InsertReservationUpdateSeat(Reservation r, int seatno)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insertReserandUpdateSeat", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@resdatee", r.resDate);
                    cmd.Parameters.AddWithValue("@restimee", r.resTime);
                    cmd.Parameters.AddWithValue("@userr", r.user);
                    cmd.Parameters.AddWithValue("@tickett", r.ticket);
                    // cmd.Parameters.AddWithValue("@seatType", s.seatType);
                    cmd.Parameters.AddWithValue("@seatNumber", seatno);


                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Reservation Successful !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable DisplayReservation()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDisplayReservation", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void DeleteReservation(Reservation r)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteReservation", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@resid", r.resid);

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Reservation Deleted Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateReservation(Reservation r)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spupdateReser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@resid", r.resid);
                    cmd.Parameters.AddWithValue("@resdate", r.resDate);
                    cmd.Parameters.AddWithValue("@restime", r.resTime);
                    cmd.Parameters.AddWithValue("@user", r.user);
                    cmd.Parameters.AddWithValue("@ticket", r.ticket);
                    //cmd.Parameters.AddWithValue("@seatNumber", seatno);
                    //cmd.Parameters.AddWithValue("@seaType", seatno);


                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Reservation Updated Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable DisplayAllEvents()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from DisplayAllEvents()", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds, "dtEvent");
                    DataTable dt = ds.Tables["dtEvent"];
                    return dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public int CountEvents()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from usdAllEvents()", con);
                    object count = cmd.ExecuteScalar();

                    return int.Parse(count.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public int daysLeft(string name)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select  dbo.calculatesEventDate ('" + name + "')", con);
                    object count = cmd.ExecuteScalar();

                    return int.Parse(count.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public int ticketLeft(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select  dbo.TicketsLeftforEvent ('" + id + "')", con);
                    object count = cmd.ExecuteScalar();

                    return int.Parse(count.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }
        public int numberofSeats(string name)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select  dbo.udfSeatsbyEvent ('" + name + "')", con);
                    object count = cmd.ExecuteScalar();

                    return int.Parse(count.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }

    }
}

    }
}
