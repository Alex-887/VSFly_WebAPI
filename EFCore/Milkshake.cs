namespace EFCore
{
    public class Milkshake : DrinkDecorator
    {
        public Milkshake(Carrier Carrier) : base(Carrier,  50)
        {


        }
    }
}
