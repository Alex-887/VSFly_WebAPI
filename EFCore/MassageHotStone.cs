using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore
{
    public class MassageHotStone : MassageDecorator
    {

        Flight flight;

        public MassageHotStone(Flight flight)
        {
            this.flight = flight;
        }


        public override string GetDescription()
        {
            return GetDescription() + " , massage with hot stone during the flight";
        }




    }
}