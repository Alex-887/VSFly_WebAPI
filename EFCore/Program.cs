using System;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating flights ... ");

            CreateDatabase();

            NewFlight();


            Console.WriteLine("Flight created");


        }




        public static void NewFlight()
        {
            using (var ctx = new VsFlightContext())
            {
                Flight flight1 = new Flight() { Departure="RDC", Destination="RDA", Date= new DateTime(), Seats= 100, Price = 1000, SeatsAvailable = 100, Description ="" };
                flight1 = new MassageHotStone(flight1);


                ctx.Add(flight1);

                ctx.SaveChanges();
            }
        }

        private static void CreateDatabase()
        {
            using (var ctx = new VsFlightContext())
            {

                var e = ctx.Database.EnsureCreated();

                if (e)
                    Console.WriteLine("Database has been created !");
            }
        }



    }




}
