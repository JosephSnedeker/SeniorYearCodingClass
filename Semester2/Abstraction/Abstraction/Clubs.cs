using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Clubs : weapons
    {
        public Clubs(float weight, float value, float damage, string effect)
                   : base(weight, value, damage, effect)
        {
            
        }
        public override void Use()
        {
            Console.WriteLine("Club with effect " + effect + " and dealing " + damage + " ");
            base.Use();
        }
    }
}
