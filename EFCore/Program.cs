using System;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating flights ... ");

            NewFlight();

            Console.WriteLine("Flights created");

        }




        public static void NewFlight()
        {


            Carrier flight1 = new Flight() { FlightNo = 9999, Departure = "RDC", Destination = "RDA", Date = new DateTime(), Seats = 100, SeatsAvailable = 100 };
            flight1 = new Alcohol(flight1);
            flight1 = new Milkshake(flight1);
            flight1 = new MassageHotStone(flight1);

            Console.WriteLine("Calculating price for flight number 1  : ");
            Console.WriteLine(flight1.GetPrice());


            Carrier flight2 = new Flight() { FlightNo = 9999, Departure = "RDC", Destination = "RDA", Date = new DateTime(), Seats = 100, SeatsAvailable = 100 };
            flight2 = new SwedishMassage(flight2);
            flight2 = new SoftDrinks(flight2);


            Console.WriteLine("Calculating price for flight number 2  : ");
            Console.WriteLine(flight2.GetPrice());


        }

    }

}
