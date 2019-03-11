using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringSplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringSploder("Hello"));
            Console.ReadKey();

        }

        static string StringSploder(string word)
        {
            String wordTwo = "";
            for (int i = 0; i < word.Length + 1; i++)
            {
                wordTwo += word.Substring(0, i);
            }
            return wordTwo;
        }
    }
}
