using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : Service<Flight>, IServiceFlights
    {

        //    //private readonly IGenericRepository<Flight> _repository;
        //    IUnitOfWork unitOfWork;

        //    //public List<Flight> Flights => GetAll().ToList();   

        //    public ServiceFlight(IUnitOfWork uof):base(uof)
        //    {
        //        //unitOfWork= uof;
        //    }

        //    //public void AddFlight(Flight flight)
        //    //{
        //    //    unitOfWork.Repository<Flight>().Add(flight);
        //    //}

        //    //public void RemoveFlight(Flight flight)
        //    //{
        //    //    unitOfWork.Repository<Flight>().Delete(flight);
        //    //}

        //    //public List<Flight> GetFlightList()
        //    //{
        //    //    return unitOfWork.Repository<Flight>().GetAll().ToList();
        //    //}



        //    public List<Flight> Flights { get; set; } = new List<Flight>();

        //    public IEnumerable<IGrouping<string,Flight>> DestinationGroupedFlights()
        //    {
        //        //var query = from f in Flights
        //        //            group f by f.Destination;
        //        var query = Flights.GroupBy(f => f.Destination);
        //        foreach (var g in query) {
        //            Console.WriteLine("Destionation "+g.Key);
        //            foreach (var v in g) {
        //                Console.WriteLine("decolage : " + v.FlightDate);
        //            }
        //        }

        //        return query;


        //    }

        //    public double DurationAverage(string destination)
        //    {
        //        var query = from f in Flights
        //                    where f.Destination == destination
        //                    select f.EstimatedDuration;
        //        //var query = Flights.Where(f => f.Destination == destination).Select(f => f.EstimatedDuration);
        //        return query.Average();
        //    }

        //    public IEnumerable<DateTime> GetFlightDates(string destination)
        //    {
        //        //List<DateTime> dates = new List<DateTime>();

        //        //for (int i = 0;i<Flights.Count;i++)
        //        //{
        //        //    if (Flights[i].Destination == destination)
        //        //    {
        //        //        dates.Add(Flights[i].FlightDate);
        //        //    }
        //        //}
        //        //return dates;
        //        //List<DateTime> dates = new List<DateTime>();
        //        //foreach (var flight in Flights)
        //        //{
        //        //    if (flight.Destination == destination)
        //        //    {
        //        //        dates.Add(flight.FlightDate);
        //        //    }
        //        //}

        //        //IEnumerable<DateTime> query = from f in Flights
        //        //                              where f.Destination == destination
        //        //                              select f.FlightDate;
        //        //return query.ToList();
        //        IEnumerable<DateTime> queryLambda = Flights
        //            .Where(f => f.Destination == destination)
        //            .Select(f=>f.FlightDate);
        //        return queryLambda;
        //    }

        //    public void GetFlights(string filterType, string filterValue)
        //    {
        //        switch(filterType)
        //        {
        //            case "Destination":
        //                foreach(Flight flight in Flights) {
        //                    if (flight.Destination.Equals(filterValue))
        //                        Console.WriteLine(flight);
        //                }
        //                break;

        //            case "FlightDate":
        //                foreach (Flight flight in Flights)
        //                {
        //                    if (flight.FlightDate == DateTime.Parse(filterValue))
        //                        Console.WriteLine(flight);
        //                }
        //                break;
        //            case "EstimatedDuration":
        //                foreach (Flight flight in Flights)
        //                {
        //                    if (flight.EstimatedDuration == int.Parse(filterValue))
        //                        Console.WriteLine(flight);
        //                }
        //                break;
        //        }
        //    }

        //    public IEnumerable<Flight> OrderedDurationFlights()
        //    {
        //        //var query = from f in Flights
        //        //            orderby f.EstimatedDuration descending
        //        //            select f;
        //        var query = Flights.OrderByDescending(f => f.EstimatedDuration).Select(f=>f);
        //        return query;
        //    }

        //    public int ProgrammedFlightNumber(DateTime startDate)
        //    {

        //            //var query = from f in Flights
        //            //            where (DateTime.Compare(f.FlightDate, startDate) > 0
        //            //    && (f.FlightDate - startDate).TotalDays < 7)
        //            //    select f;
        //            var query = Flights.Where(f=>(DateTime.Compare(f.FlightDate,startDate) < 0) && (f.FlightDate-startDate).TotalDays<7);


        //        return query.Count();
        //    }

        //    public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        //    {
        //        //var query = from p in flight.Passengers.OfType<Traveller>()
        //        //            orderby p.Birthdate ascending
        //        //            select p ;
        //        //var query = flight.Passengers.OfType<Traveller>().OrderBy(p => p.Birthdate).Select(p => p);
        //        return /*query.Take(3)*/ null;
        //    }

        //    public void ShowFlightDetails(Plane plane)
        //    {
        //        //var query = from f in Flights 
        //        //            where f.Plane == plane
        //        //            select f;
        //        var query = Flights.Where(f => f.Plane == plane).Select(f => f);
        //        foreach (var f in query)
        //        {
        //            Console.WriteLine("destination : "+f.Destination+" flightDate: "+f.FlightDate);
        //        }   
        //    }


        //    public Action<Plane> FlightDetailsDel;

        //    public Func<string, double> DurationAverageDel;

        //    //public ServiceFlight()
        //    //{
        //    //    FlightDetailsDel = plane => {
        //    //        var query = from f in Flights
        //    //                    where f.Plane == plane
        //    //                    select f;
        //    //        foreach (var f in query)
        //    //        {
        //    //            Console.WriteLine("destination : " + f.Destination + " flightDate: " + f.FlightDate);
        //    //        }
        //    //    };
        //    //    DurationAverageDel = destination => {
        //    //        var query = from f in Flights
        //    //                    where f.Destination == destination
        //    //                    select f.EstimatedDuration;
        //    //        return query.Average();
        //    //    };
        //    //}
        //}

        public List<Flight> Flights => GetAll().ToList();
        public ServiceFlight(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    } }

