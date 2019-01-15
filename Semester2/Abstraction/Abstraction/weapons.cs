using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class weapons : Items
    {
       protected float damage;
       protected string effect;
       
       public weapons(float weight, float value, float damage, string effect)
            : base(weight, value)
        {
                           
            this.damage = damage;
            this.effect = effect;
        }
    }
}
