using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Stadium
{
    class Reservation
    {
        public int resid;
        public string resDate;
        public string resTime;
        public int noofReservation;
        public string user;
        public int ticket;



        public Reservation()
        {

        }
        public Reservation(int resid, string resDate, string resTime, int noofReservation, string user, int ticket)
        {
            this.resid = resid;
            this.resDate = resDate;
            this.resTime = resTime;
            this.noofReservation = noofReservation; 
            this.user = user;
            this.ticket = ticket;
        }
        public Reservation(string resDate, string resTime,string user, int ticket)
        {
            this.resDate = resDate;
            this.resTime = resTime;
            this.user = user;
            this.ticket = ticket;
        }
        public Reservation(int resid,string resDate, string resTime, string user, int ticket)
        {
            this.resid = resid;
            this.resDate = resDate;
            this.resTime = resTime;
            this.user = user;
            this.ticket = ticket;
        }
        public Reservation(int resid)
        {
            this.resid = resid;
           
        }

    }
}