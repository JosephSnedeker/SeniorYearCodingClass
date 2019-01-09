using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = 6;
            Print(a);
            int[] b = new int[] { 5, 3, 7 };
            Print(b);
            int[,] c = new int[5, 10];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = rand.Next(1, 10); 
                }
            }
            Print(c);
            int[][] d = new int[5][];
            int[] d1 = new int[] { 5, 6, 7, 2 };
            int[] d2 = new int[] { 4, 3, 7, 5 };
            int[] d3 = new int[] { 4, 5 };
            int[] d4 = new int[] { 3, 6, 8, 2 };
            int[] d5 = new int[] { 5, 6, 7};

            d[0] = d1;
            d[1] = d2;
            d[2] = d3;
            d[3] = d4;
            d[4] = d5;
            Print(d);
            Console.ReadKey();

        }
        static void Print(int a)
        {
            Console.WriteLine(a);
        }
         static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Print(int[][] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    
    }
}
