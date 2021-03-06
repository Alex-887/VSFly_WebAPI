﻿namespace EFCore
{
    public abstract class MassageDecorator : Carrier
    {
        public Carrier Carrier;

        public MassageDecorator(Carrier Carrier, decimal Price) : base(Price)
        {

            this.Carrier = Carrier;

        }

        public override decimal GetPrice()
        {
                return Carrier.Price += Price;
        }




    }
}