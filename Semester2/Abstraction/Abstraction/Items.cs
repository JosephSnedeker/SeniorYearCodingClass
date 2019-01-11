using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Items
    {
        protected float weight;
        protected float value;
        public Items(float weight, float value)
        {
            this.weight = weight;
            this.value = value;
        }
        public virtual void Use()
        {
            Console.WriteLine(" was used");
        }
       
    }
 
}
