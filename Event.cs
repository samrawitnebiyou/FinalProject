using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadium
{
    class Event
    {

        public int id;
        public string name;
        public string date;
        public string time;

      public Event(int id)
        {
            this.id = id;
        }
        public Event(int id, string name, string date, string time)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.time = time;
        }
        
    }
}
    
