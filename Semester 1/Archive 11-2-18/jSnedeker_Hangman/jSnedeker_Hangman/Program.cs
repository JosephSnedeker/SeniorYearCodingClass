using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jSnedeker_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[21];
            words[0] = "hello";
            words[1] = "mountanious";
            words[2] = "encroach";
            words[3] = "stage";
            words[4] = "surpass";
            words[5] = "present";
            words[6] = "past";
            words[7] = "future";
            words[8] = "shake";
            words[9] = "swing";
            words[10] = "rainy";
            words[11] = "withdraw";
            words[12] = "anxious";
            words[13] = "clever";
            words[14] = "juicy";
            words[15] = "light";
            words[16] = "stem";
            words[17] = "baseball";
            words[18] = "cowardly";
            words[19] = "distribution";
            words[20] = "giant";

            int x = 1;

            Random rand = new Random();
            
            string word = words[rand.Next(0, 20)];
            Console.WriteLine(word);
            string user = "5";

            Console.WriteLine();

            for (int i = 0; i < 6; i++) 
                
            {
                
                Console.WriteLine("Type a letter and press enter to guess");
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == user[0])
                        Console.Write(word[j]);
                    if (word[j] != user[0])
                        Console.Write("*");
                }
                Console.WriteLine();
                user = Console.ReadLine();
                for (int k = 0; k < word.Length; k++)

                {

                    if (user[0] == word[i])
                    {

                        Console.WriteLine("Correct, any key to next");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }


            } 


            Console.ReadKey();
        }
    }
}
