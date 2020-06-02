namespace EFCore
{
    public class Alcohol : DrinkDecorator
    {
        public Alcohol(Carrier Carrier) : base(Carrier, 100)
        {
        }
    }
}
