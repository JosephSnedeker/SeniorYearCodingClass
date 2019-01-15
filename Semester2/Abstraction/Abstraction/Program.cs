using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Items> Inventory = new List<Items>();
            Items Darkreigh = new Blades(5, 55, 6, "burn", 3);
            Items Pikachu = new Blades(2, 33, 4, "stun", 7);
            Items Chimchar = new Clubs(7, 37, 7, "topple");
            Items Charizard = new Clubs(9, 90, 11, "burn");
            Items Gardevoir = new HealCon(1, 15, 5, 25);
            Items Reshiram = new HealCon(1, 50, 1, 500);
            Items Incineroar = new EffectCon(1, 25, 2, "PowUp");
            Items Squirtle = new EffectCon(1, 30, 2, "ManaUp");
            Items Ivysaur = new QuestItems(5, -1);
            Items Weavile = new QuestItems(5, -1);
            Inventory.Add(Darkreigh);
            Inventory.Add(Pikachu);
            Inventory.Add(Chimchar);
            Inventory.Add(Charizard);
            Inventory.Add(Gardevoir);
            Inventory.Add(Reshiram);
            Inventory.Add(Incineroar);
            Inventory.Add(Squirtle);
            Inventory.Add(Ivysaur);
            Inventory.Add(Weavile);
            for (int i = 0; i < Inventory.Count-1; i++)
            {
                Inventory[i].Use();
            }
            Console.ReadKey();



        }
    }
}
