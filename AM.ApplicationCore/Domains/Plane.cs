using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType { Boing,AirBus}

    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "manufacture date : "+this.ManufactureDate;
        }

 /*       public Plane() { }

        public Plane(PlaneType type,int capacity,DateTime date)
        {
            this.Capacity = capacity;
            this.ManufactureDate = date;
            this.PlaneType = type;
        }
 */
    }
}
