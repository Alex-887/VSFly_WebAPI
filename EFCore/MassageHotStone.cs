namespace EFCore
{
    public class MassageHotStone : MassageDecorator
    {
        public MassageHotStone(Carrier Carrier) : base(Carrier, 500)
        {
        }
    }
}