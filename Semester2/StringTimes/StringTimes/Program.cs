using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(stringTimes("hi", 3));
            Console.ReadKey();
        }
        static string stringTimes(string word, int n)
        {
            if (n < 0)
            {
                return "invalid n";
            }
            string extendedString = "";
            for (int i = 0; i < n; i++)
            {
                extendedString += word;
            }
            return extendedString;
        }
    }
}

