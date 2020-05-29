using System.ComponentModel.DataAnnotations;

namespace WebAPITuto.Models
{
    public class Booking
    {

        [Key]
        public int BookingNo { get; set; }

        //flight - passenger
        public int FlightNo { get; set; }
        public int PassengerId { get; set; }

        //virtual, someone will be able to inherit booking and to modify the getter and setter from passenger
        //polymorphysme / override this, must be virtual

        public decimal SalePrice { get; set; }
    }
}