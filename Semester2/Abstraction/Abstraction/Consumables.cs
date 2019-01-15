using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Consumables : Items
    {
        protected float uses;
        

        public Consumables(float weight, float value, float uses)
             : base(weight, value)
        {
            this.weight = weight;
            this.value = value;
            this.uses = uses;
        }
    }
}
