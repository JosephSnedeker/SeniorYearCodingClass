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

        public Character(string name, int strength, int tenacity, int utility, int perception, int intelligence, int dexterity)
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
