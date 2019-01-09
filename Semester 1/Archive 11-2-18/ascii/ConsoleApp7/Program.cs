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


                if (x == 1)
                {
                    Console.WriteLine();
                    for (int i = 0; i < 1; i++)
                    {

                        for (int j = 0; j < 1; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                if (x == 2)
                {
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {

                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                if (x == 3)
                {
                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {

                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();

                    }

                }
                if (x == 4)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = (5 - i); j < 6; j++)
                        {
                            Console.Write("X");

                        }
                        Console.WriteLine();
                    }
                }

                if (x == 7)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = (5 - i); j < 6; j++)
                        {
                            Console.Write(" ");

                        }
                        for (int j = (0 + i); j < 5; j++)

                        {
                            Console.Write("X");

                        }
                        Console.WriteLine();
                    }
                }
                if (x == 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j == i)
                            {
                                Console.Write(" ");

                            }
                            else
                            {
                                Console.Write("X");
                            }
                        }

                        Console.WriteLine();
                    }
                }

            }

        }
    }
}
