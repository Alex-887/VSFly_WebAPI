using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore
{
    public abstract class Carrier
    {

        public decimal Price;

        public Carrier()
        {

        }

        public Carrier(decimal Price)
        {
            this.Price = Price;
        }


        public abstract decimal GetPrice();

        //public virtual string GetDescription
        //{
        //    get
        //    {
        //        return this.Description;
        //    }
        //}

        //public virtual decimal GetPrice
        //{
        //    get
        //    {
        //        return this.Price;
        //    }
        //}




    }
}