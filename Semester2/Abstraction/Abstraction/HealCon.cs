using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class HealCon : Consumables
    {
        protected float heal;
        public HealCon(float weight, float value, float uses, float heal)
            : base(weight, value, uses)
        {
            this.heal = heal;

        }
        public override void Use()
        {
            Console.WriteLine("potion of healing worth " + heal + " ");
            base.Use();
        }
    }
}
