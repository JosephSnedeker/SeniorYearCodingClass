using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSnedeker_CharacterLoadSave
{
    class Character
    {
        public string name;
        public int strength;
        public int tenacity;
        public int utility;
        public int perception;
        public int intelligence;
        public int dexterity;

        public Character(string name =  "default", int strength = 0, int tenacity = 0, int utility = 0, int perception = 0, int intelligence = 0, int dexterity = 0)
        {
            this.name = name;
            this.strength = strength;
            this.tenacity = tenacity;
            this.utility = utility;
            this.perception = perception;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
        }
    }
    
}
