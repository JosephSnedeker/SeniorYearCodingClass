using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Math.PI;
            Console.WriteLine("Please Choose a Precision Value");
            int precision = int.Parse(Console.ReadLine());
            
            Print(x, precision);
            Console.ReadKey();


        }
        static void Print(double x, int y = 2)
        {
            string stringholder = "0.";
            int precision = y;
            for (int i = 0; i < y; i++)
            {
                stringholder = stringholder + "#";
            }
            Console.WriteLine(x.ToString(stringholder));


        }
    }
}
