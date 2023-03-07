// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Domains;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

Console.WriteLine("hello");
/*Plane p1= new Plane();
p1.Capacity = 200;
p1.ManufactureDate = new DateTime(2023, 01, 01);
p1.PlaneType = PlaneType.AirBus;*/

////Plane p2 = new Plane(PlaneType.Boing, 500, new DateTime(2022, 05, 23));


//Plane p3 = new Plane
//{
//    Capacity = 250,
//    ManufactureDate = new DateTime(2020, 02, 02),
//    PlaneType = PlaneType.AirBus,
//};

Passenger passenger1 = new Passenger
{
    FullName = new FullName
    {
        FirstName = "khaled",
        LastName = "gaaieb",
    },
    EmailAddress = "khaled.gaaieb@esprit.tn",

};

//Console.WriteLine(passenger1.CheckProfile("ahmed", "foulen"));

//Console.WriteLine(passenger1.CheckProfile("Khaled", "Gaaieb","khaled.gaaieb@esprit.tn"));

//Traveller traveller1 = new Traveller
//{
//    FirstName = "ahmed",
//    LastName = "bouhmid",
//    Nationality = "tounsi",
//};

//Console.WriteLine("Traveller 1 : ");
//traveller1.PassengerType();

//Staff staff1 = new Staff
//{
//    FirstName = "joseph",
//    LastName = "talhaoui",
//    Function = "xxxx",
//};
//Console.WriteLine("Staff 1 : ");
//staff1.PassengerType();

ServiceFlight sF =new ServiceFlight();
sF.Flights = TestData.listFlights;

foreach(var item in sF.GetFlightDates("Paris"))
{
    Console.WriteLine(item);
}

sF.GetFlights("Destination", "Madrid");

sF.FlightDetailsDel(TestData.BoingPlane);
Console.WriteLine("total flights :" + sF.ProgrammedFlightNumber(new DateTime(2022,02,01)));

Console.WriteLine("average estimated time : " +sF.DurationAverageDel("Paris"));

foreach(var item in sF.OrderedDurationFlights()) { Console.WriteLine(item); } 

foreach(var item in sF.SeniorTravellers(TestData.flight1)) { Console.WriteLine(item); }

sF.DestinationGroupedFlights();

Console.WriteLine(passenger1.FullName.FirstName + passenger1.FullName.LastName);
passenger1.UpperFullName();
Console.WriteLine(passenger1.FullName.FirstName + passenger1.FullName.LastName);

AMContext ctx = new AMContext();
ctx.Flights.Add(TestData.flight1);
ctx.SaveChanges();