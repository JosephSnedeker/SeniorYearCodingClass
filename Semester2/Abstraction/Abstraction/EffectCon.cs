using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class EffectCon : Consumables
    {
        protected string effect;
        public EffectCon(float weight, float value, float uses, string effect)
            : base(weight, value, uses)
        {
            this.effect = effect;
            
        }
        public override void Use()
        {
            Console.WriteLine("potion of " + effect + " ");
            base.Use();
        }
    }
}
