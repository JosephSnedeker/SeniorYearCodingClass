using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsnedeker_Scope1
{
    class Program
    {
        static int x = 1;
        static void Main(string[] args)
        {

            while (x != 0)
            {
                x = menu();

                if (x == 1)
                    print3x3square();
                if (x == 2)
                    print3x6square();
                if (x == 3)
                    print6x3square();
            }

        }
        static void print3x3square()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                    Console.Write("X");
                Console.WriteLine();
                
            }
            Console.ReadKey();
            Console.Clear();

        }
        static void print3x6square()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write("X");
                Console.WriteLine();
                
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void print6x3square()
        {
            Console.Clear();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("X");
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
        }
        static int menu()
        {
            Console.WriteLine("Please select an option");
            Console.WriteLine("*********************");
            Console.WriteLine("1. print 3x3 square");
            Console.WriteLine("2. print 6x3 square");
            Console.WriteLine("3. print 3x6 square");
            Console.WriteLine("0. Quit");
            Console.WriteLine("*********************");
            x = int.Parse(Console.ReadLine());
            return x;
        }
    }
}
