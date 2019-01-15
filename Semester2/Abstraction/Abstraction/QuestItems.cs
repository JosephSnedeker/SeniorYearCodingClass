using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class QuestItems : Items
    {
        protected float damage;
        protected string effect;

        public QuestItems(float weight, float value)
             : base(weight, value)
        {

            
        }
        public override void Use()
        {
            Console.WriteLine("The quest using this item has been completed");
        }
    }
}
