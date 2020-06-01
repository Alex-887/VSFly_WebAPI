﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore
{
    public class Flight
    {

        [Key]
        public int FlightNo { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public int Seats { get; set; }
        public decimal Price { get; set; }
        public int SeatsAvailable { get; set; }
        public string Description;


        public virtual string GetDescription
        {

            get
            {
                return Description;
            }

        }







    }
}