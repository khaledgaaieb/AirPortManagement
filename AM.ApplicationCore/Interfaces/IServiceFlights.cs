﻿using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlights : IService<Flight>
    {
        //public void AddFlight(Flight flight);
        //public void RemoveFlight(Flight flight);
        //public List<Flight> GetFlightList();

        //IEnumerable<DateTime> GetFlightDates(string destination);
        //void GetFlights(string filterType, string filterValue);

        //void ShowFlightDetails(Plane plane);
        //int ProgrammedFlightNumber(DateTime startDate);
        //double DurationAverage(string destination);
        //IEnumerable<Flight> OrderedDurationFlights();

        //IEnumerable<Traveller> SeniorTravellers(Flight flight);
        //IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
        //object? GetMany();
    }
}
