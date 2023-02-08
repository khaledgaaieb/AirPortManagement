using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight:IServiceFlights
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            //List<DateTime> dates = new List<DateTime>();

            //for (int i = 0;i<Flights.Count;i++)
            //{
            //    if (Flights[i].Destination == destination)
            //    {
            //        dates.Add(Flights[i].FlightDate);
            //    }
            //}
            //return dates;
            //List<DateTime> dates = new List<DateTime>();
            //foreach (var flight in Flights)
            //{
            //    if (flight.Destination == destination)
            //    {
            //        dates.Add(flight.FlightDate);
            //    }
            //}

            IEnumerable<DateTime> query = from f in Flights
                                          where f.Destination == destination
                                          select f.FlightDate;
            return query.ToList();
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch(filterType)
            {
                case "Destination":
                    foreach(Flight flight in Flights) {
                        if (flight.Destination.Equals(filterValue))
                            Console.WriteLine(flight);
                    }
                    break;

                case "FlightDate":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.FlightDate == DateTime.Parse(filterValue))
                            Console.WriteLine(flight);
                    }
                    break;
                case "EstimatedDuration":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.EstimatedDuration == int.Parse(filterValue))
                            Console.WriteLine(flight);
                    }
                    break;
            }
        }


    }
}
