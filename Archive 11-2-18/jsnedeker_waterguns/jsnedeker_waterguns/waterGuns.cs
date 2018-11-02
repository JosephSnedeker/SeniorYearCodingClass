using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsnedeker_waterguns
{
    class waterGuns
    {
        float capacity = 1;
        bool isWet;
        Random rand = new Random();

        public waterGuns()
        { }
        public bool Shoot(float amount)
        {
            if (capacity > 0)
            {
                capacity -= amount;
                float percentChance = (.2f * amount) + .1f;
                if (rand.NextDouble() < percentChance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public void refill()
        {
            capacity += .25f;
        }

    }
}
