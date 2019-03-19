using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringBits("Hello"));

        }
        static private string StringBits(string word)
        {
            string stringToReturn = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    stringToReturn += word[i];
                }
            }
            return stringToReturn;
        }
    }

}
