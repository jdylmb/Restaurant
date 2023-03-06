using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Reservation
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int PartySize { get; set; }
        public Table Table { get; set; }

        public Reservation(DateTime startTime, DateTime endTime, int partySize, Table table)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.PartySize = partySize;
            this.Table = table;
        }
    }
}
