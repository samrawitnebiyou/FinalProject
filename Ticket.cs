using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadium
{
    class Ticket
    {

        public int ticketid;
        public string tickettype;
        public string amount;
        public string eventname;

        public Ticket()
        {

        }
        public Ticket(int ticketid)
        {
            this.ticketid = ticketid;

        }
        public Ticket(int ticketid, string tickettype,string amount, string eventname)
        {
            this.ticketid = ticketid;
            this.tickettype = tickettype;
            this.amount = amount;
            this.eventname = eventname;
        }
        public Ticket( string tickettype, string amount, string eventname)
        {
           
            this.tickettype = tickettype;
            this.amount = amount;
            this.eventname = eventname;
        }
    }
}
