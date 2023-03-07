using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domains
{
    public class Ticket
    {
        public double prix { get; set; }
        public int siege { get; set; }
        public bool vip { get; set; }

        public Passenger Passenger { get; set; }
        public Flight Flight { get; set; }

        public int FlightFk { get; set; }
        public string PassengerFk { get; set; }
    }
}
