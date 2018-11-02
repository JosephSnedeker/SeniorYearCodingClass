using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullaskii
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 13001; i++)
            {
                int askii = i;
                char letter = (char)askii;
                Console.Write(i + "=" + letter + " : ");
            }
            Console.ReadKey();
        }
    }
}
