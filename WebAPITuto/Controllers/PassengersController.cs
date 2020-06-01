using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace WebAPITuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        private readonly VsFlightContext _context;

        public PassengersController(VsFlightContext context)
        {
            _context = context;
        }

        // GET: api/Passengers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passenger>>> GetPassengerSet()
        {
            return await _context.Passenger.ToListAsync();
        }


        // GET: api/Passengers/GetAllTicketsForDestination/destination
        [HttpGet("GetAllTicketsForDestination/{destination}")]
        public List<Passenger> GetAllTicketsForDestination(string destination)
        {
            return (from f in _context.Flight

                    join p in _context.Passenger on f.FlightNo equals p.FK_FlightNo
                    where f.Destination == destination
                    select p).ToList();
        }



        // GET: api/Passengers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Passenger>> GetPassenger(int id)
        {
            var passenger = await _context.Passenger.FindAsync(id);

        

            if (passenger == null)
            {
                return NotFound();
            }

            return passenger;
        }


        // POST: api/Passengers
        [HttpPost]
        public async Task<ActionResult<Passenger>> PostPassenger(Passenger passenger)
        {
            _context.Passenger.Add(passenger);

            LessSeats(passenger.FK_FlightNo);


            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPassenger", new { id = passenger.PassengerId }, passenger);
        }

        // GET: api/Flights/LessSeats/id
        [HttpGet("LessSeats/{id}")]
        public void LessSeats(int id)
        {
            Flight flight = _context.Flight.Find(id);

            flight.SeatsAvailable = flight.SeatsAvailable - 1;


        }



    }
}
