namespace EFCore
{
    public abstract class DrinkDecorator : Carrier
    {

        public Carrier Carrier;

        public DrinkDecorator(Carrier Carrier, decimal Price) : base(Price)
        {
            this.Carrier = Carrier;
        }


        public override decimal GetPrice()
        {
             return Carrier.Price+=Price;
        }



    }
}
