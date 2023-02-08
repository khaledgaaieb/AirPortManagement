// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Domains;
using AM.ApplicationCore.Services;


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

//Passenger passenger1 = new Passenger
//{
//    FirstName = "Khaled",
//    LastName = "Gaaieb",
//    EmailAddress = "khaled.gaaieb@esprit.tn",

//};

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

ServiceFlight sF=new ServiceFlight();
sF.Flights = TestData.listFlights;

foreach(var item in sF.GetFlightDates("Paris"))
{
    Console.WriteLine(item);
}

sF.GetFlights("Destination", "Madrid");
