using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jSnedeker_hangman2
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> userList = new List<string>();
            Random rand = new Random();

            Console.WriteLine("*******Welcome To WHEEL OF HANGMAN*******");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Quit");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)

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
                string word = words[rand.Next(0, 20)];
                int y = 1;
                int z = 0;
                do
                {
                    
                    Console.WriteLine(word);
                    for (int i = 0; i < word.Length; i++)
                    {
                        Console.Write("*");
                       
                    }
                    Console.WriteLine();
                    for (int i = 0; i < word.Length; i++)       

                    {
                        
                        Console.WriteLine("please enter a letter");
                        Console.WriteLine();
                        userList.Add(Console.ReadLine());


                        for (int j = 0; j < userList.Count; j++)
                        {
                            // print out letters correct
                            if (word.Contains(userList[j]))
                            {
                                Console.Write(word[j]);
                            }
                            else
                            {
                                Console.WriteLine("*");
                            }
                            z++;
                        }


                    }

                    z++;
                } while (y != 0);

                    



            }


            else if (x == 2) ;


        }
    }
}
