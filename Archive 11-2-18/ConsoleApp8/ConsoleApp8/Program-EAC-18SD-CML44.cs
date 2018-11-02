using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the \"Roller Coaster Computer\" ");
            int x = 0;
            while (x != 9)
            {

                Console.WriteLine("1. Place rider in a seat");
                Console.WriteLine("2. List available seats");
                Console.WriteLine("3. Send out the coaster!!!");
                Console.WriteLine("4. Quit the program");

                Random rand = new Random();
                int[] rollerCoasterSeats = new int[10];
                for (int i = 0; i < 10; i++)
                    rollerCoasterSeats[i] = i;

                x = int.Parse(Console.ReadLine());
                if (x == 1)
                    for (int i = 1; i < 10; i++)
                    {
                        if (rollerCoasterSeats[i] == 1)
                        {
                            Console.WriteLine("Working");
                        }
                        else
                        {
                            rollerCoasterSeats[i] = 1;
                            i = 10;
                        }
                    }
                        



                    










            }
        }
    }
}
