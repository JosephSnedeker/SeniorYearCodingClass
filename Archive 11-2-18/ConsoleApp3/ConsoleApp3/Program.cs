using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x != 9)
            {

                Console.WriteLine("______________________");
                Console.WriteLine("1. 1X1 square");
                Console.WriteLine("2. 3X3 square");
                Console.WriteLine("3. 4X4 square");
                Console.WriteLine("4. Triangle");
                Console.WriteLine("5. Special");
                Console.WriteLine("9. Quit");

                x = int.Parse(Console.ReadLine());
                if (x == 2)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine("x");
                    }
                }
            }



        }
    }
}
