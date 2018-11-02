using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskiiAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 97; i < 123; i++)
            {
                Console.WriteLine(alpha[i - 97] + " = " + i);
            }
            Console.ReadKey();

        }
    }
}
