using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore
{
    public abstract class Carrier
    {

        public Carrier()
        {
            Description = "This carrier belongs to VsFlight Corporation.";
        }
        
        public string Description { get; set; }

        public string GetDescription()
        {
            return Description;
        }


    }
}