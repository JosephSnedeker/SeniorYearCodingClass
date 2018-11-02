using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskiiProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int user = 1;
            while (user != 0)
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("1. a - z");
                Console.WriteLine("2. all symbols");
                Console.WriteLine("0. Quit");
                Console.WriteLine("*************************************");
                user = int.Parse(Console.ReadLine());
                if (user == 1)
                    az();
                if (user == 2)
                    all();
                 
            }
        }

        static void az()
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 97; i < 123; i++)
            {
                Console.WriteLine(alpha[i - 97] + " = " + i);
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void all()
        {
            for (int i = 0; i < 13001; i++)
            {
                int askii = i;
                char letter = (char)askii;
                Console.Write(i + "=" + letter + " : ");
            }
            Console.ReadKey();
            Console.Clear();
        }

    }
    
}
