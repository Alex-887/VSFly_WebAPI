using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPITuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly VsFlightContext _context;

        public FlightsController(VsFlightContext context)
        {
            _context = context;
        }

        // GET: api/Flights
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> GetFlightSet()
        {
            return await _context.Flight.Where(flight => flight.SeatsAvailable > 0).ToListAsync();
        }




        // GET: api/Flights/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetFlight(int id)
        {
            var flight = await _context.Flight.FindAsync(id);

            if (flight == null)
            {
                return NotFound();
            }

            //If the airplane is more than 80% full regardless of the date:
            if (flight.Seats / 100 * 20 > flight.SeatsAvailable)
                flight.Price = flight.Price / 100 * 150;
            else
            {
                //If the plane is filled less than 20 % less than 2 months before departure:
                if (flight.Seats / 100 * 80 < flight.SeatsAvailable && ( flight.Date - DateTime.Now).TotalDays < 60.0)
                    flight.Price = flight.Price / 100 * 80;

                else
                {
                    //If the plane is filled less than 50 % less than 1 month before departure:
                    if (flight.Seats / 100 * 50 < flight.SeatsAvailable && ( flight.Date- DateTime.Now).TotalDays < 30.0)
                        flight.Price = flight.Price / 100 * 70;

                    else
                    {
                        //In all other cases:
                        flight.Price = flight.Price;
                    }

                }
            }




            return flight;
        }



        // GET: api/Flights/GetAverageSalePriceForDestination/destination
        [HttpGet("GetAverageSalePriceForDestination/{destination}")]
        public decimal GetAverageSalePriceForDestination(string destination)
        {
            var averagePriceDestination = (from f in _context.Flight
                                           join p in _context.Passenger on f.FlightNo equals p.FK_FlightNo
                                           where f.Destination == destination
                                           select p.SalePrice).Average();



            return averagePriceDestination;

        }



        // GET: api/Flights/GetSalePricesFromAFlight/3
        [HttpGet("GetSalePricesFromAFlight/{id}")]
        public decimal GetSalePricesFromAFlight(int id)
        {
            //Passenger passenger = (Passenger)_context.Passenger.Where(passenger => passenger.FK_FlightNo.Equals(flightNo));

            decimal totalSalePrices = _context.Passenger
            .Where(passenger => passenger.FK_FlightNo.Equals(id))
            .Sum(passenger => passenger.SalePrice);

            return totalSalePrices;

        }



        // POST: api/Flights
        [HttpPost]
        public async Task<ActionResult<Flight>> PostFlight(Flight flight)
        {
            return CreatedAtAction(nameof(GetFlightSet), new { id = flight.FlightNo }, flight);
        }


        
    }
}
