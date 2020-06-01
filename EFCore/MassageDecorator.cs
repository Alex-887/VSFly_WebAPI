using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore
{
    public abstract partial class MassageDecorator : Flight
    {

        public abstract string GetDescription();



    }
}