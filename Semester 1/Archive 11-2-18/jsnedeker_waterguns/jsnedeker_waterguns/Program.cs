using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsnedeker_waterguns
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int derp = 1;
            while (derp != 0)
            {
                Console.WriteLine("DUEL");
                waterGuns player1 = new waterGuns();
                waterGuns player2 = new waterGuns();
                Console.WriteLine("Player 1: ");
                Console.WriteLine("1. Shoot 2. Refill");
                int x1 = int.Parse(Console.ReadLine());
                if (x1 == 1)
                {
                    Console.WriteLine("enter amount to shoot");
                    float z = float.Parse(Console.ReadLine());
                    if (player1.Shoot(z) == true)
                    {
                        Console.WriteLine("Ya got em wet");

                    }
                    else
                    {
                        Console.WriteLine("Ya missed");
                    }
                }
                if (x1 == 2)
                {
                    player1.refill();
                }
            }


        }
    }
}

