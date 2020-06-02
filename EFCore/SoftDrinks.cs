namespace EFCore
{
    public class SoftDrinks : DrinkDecorator
    {
        public SoftDrinks(Carrier Carrier) : base(Carrier,  30)
        {


        }
    }
}
