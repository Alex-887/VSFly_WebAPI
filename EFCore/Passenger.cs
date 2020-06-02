using System.ComponentModel.DataAnnotations;

namespace EFCore
{
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public int FK_FlightNo { get; set; }
        public decimal SalePrice { get; set; }
    }
}
