using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jSnedeker_Palindromes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input text here:");
            string fullText = Console.ReadLine();
            fullText = fullText.ToLower();

            fullText = fullText.Replace(" ", "").Replace(".", "").Replace(",", "").Replace("?", "").Replace("!", "").Replace("\"", "");

            for (int i = 0; i < fullText.Length; i++)
            {
                if (fullText[i] == fullText[fullText.Length - 1 - i])
                {
                    Console.WriteLine(fullText + " is a palindrome");
                    i = fullText.Length;
                }
                else
                {
                    Console.WriteLine(fullText + " is not a palindrome");
                    i = fullText.Length;
                }

                Console.ReadKey();
            }
        }
    }
}
