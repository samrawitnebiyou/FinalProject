using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadium
{
    internal class Seat
    {
        public int seatNumber;
        public string seatType;
        public int reservation;


        public Seat()
        {

        }

        public Seat(int seatNumber, string seatType, int reservation)
        {
            this.seatNumber = seatNumber;
            this.seatType = seatType;
            this.reservation = reservation;
        }
        public Seat(int seatNumber)
        {
            this.seatNumber = seatNumber;

        }
    }
}
