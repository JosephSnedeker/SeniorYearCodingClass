using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Blades : weapons
    {
        protected float sharpness;
        public Blades(float weight, float value,float damage, string effect, float sharpness)
            : base(weight, value, damage, effect)
        {
            
            this.sharpness = sharpness;
        }
        public override void Use()
        {
            Console.WriteLine("Blade of sharpness " + sharpness + " with " + effect + " dealing " + damage + " ");
            base.Use();
        }
    }
}
