using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSnedeker_Palindromes
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input text here:");
            string fullText = Console.ReadLine();
            fullText = fullText.Replace(" ", "").Replace(".", "").Replace(",", "").Replace("?", "").Replace("!", "").Replace("\"", "");
            for (int i = 0; i < fullText.Length; i++)
            {
                
                if (fullText[i] == fullText[i + 2])
                {
                    Console.WriteLine("Palindrome Found");
                    for (int j = i; j < i + 3; j++)
                        Console.Write(fullText[j]);
                    Console.ReadKey();
                    if (i + 3 == fullText.Length)
                    {
                        i = fullText.Length;
                    }

                }
                if (fullText[i] == fullText[i + 3] && fullText[i + 1] == fullText[i + 2])
                {
                    Console.WriteLine("Palindrome Found");
                    for (int j = i; j < i + 4; j++)
                        Console.Write(fullText[j]);
                    Console.ReadKey();
                    if (i + 4 == fullText.Length)
                    {
                        i = fullText.Length;
                    }

                }
                if (fullText[i] == fullText[i + 4] && fullText[i + 1] == fullText[i + 3])
                {
                    Console.WriteLine("Palindrome Found");
                    for (int j = i; j < i + 5; j++)
                        Console.Write(fullText[j]);
                    Console.ReadKey();
                    if (i + 5 == fullText.Length)
                    {
                        i = fullText.Length;
                    }

                }
                if (fullText[i] == fullText[i + 5] && fullText[i + 1] == fullText[i + 4] && fullText[i + 2] == fullText[i + 3])
                {
                    Console.WriteLine("Palindrome Found");
                    for (int j = i; j < i + 6; j++)
                        Console.Write(fullText[j]);
                    Console.ReadKey();
                    if (i + 6 == fullText.Length)
                    {
                        i = fullText.Length;
                    }

                }
                if (fullText[i] == fullText[i + 6] && fullText[i + 1] == fullText[i + 5] && fullText[i + 2] == fullText[i + 4])
                {
                    Console.WriteLine("Palindrome Found");
                    for (int j = i; j < i + 7; j++)
                        Console.Write(fullText[j]);
                    Console.ReadKey();
                    if (i + 7 == fullText.Length)
                    {
                        i = fullText.Length;
                    }

                }
                if (fullText[i] == fullText[i + 7] && fullText[i + 1] == fullText[i + 6] && fullText[i + 2] == fullText[i + 5] && fullText[i + 3] == fullText[i + 4])
                {
                    Console.WriteLine("Palindrome Found");
                    for (int j = i; j < i + 8; j++)
                        Console.Write(fullText[j]);
                    Console.ReadKey();
                    if (i + 8 == fullText.Length)
                    {
                        i = fullText.Length;
                    }

                }
                if (fullText[i] == fullText[i + 8] && fullText[i + 1] == fullText[i + 7] && fullText[i + 2] == fullText[i + 6] && fullText[i + 3] == fullText[i + 5])
                {
                    Console.WriteLine("Palindrome Found");
                    for (int j = i; j < i + 9; j++)
                        Console.Write(fullText[j]);
                    Console.ReadKey();
                    if (i + 8 == fullText.Length)
                    {
                        i = fullText.Length;
                    }

                }




            }

            Console.ReadKey();

        }
    }
}
