﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Console.WriteLine();
            Problem4();
            Console.WriteLine();
            Problem3();
            Console.ReadKey();
            

        }
        static void Problem1()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in_.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                float total = 0;
                while (sr.Peek() > -1)
                {
                    string coin = sr.ReadLine();
                    if (coin.Contains("QUARTER"))
                    {
                        coin = coin.Substring(8);
                        total += float.Parse(coin) * .25f;


                    }
                    else if (coin.Contains("NICKEL"))
                    {
                        coin = coin.Substring(7);
                        total += float.Parse(coin) * .05f;

                    }
                    else if (coin.Contains("DIME"))
                    {
                        coin = coin.Substring(5);
                        total += float.Parse(coin) * .10f;

                    }
                    else if (coin.Contains("PENNY"))
                    {
                        coin = coin.Substring(6);
                        total += float.Parse(coin) * .01f;

                    }
                    else if (coin.Contains("HALFDOLLAR"))
                    {
                        coin = coin.Substring(11);
                        total += float.Parse(coin) * .50f;

                    }
                    else
                    {

                    }

                }

                Console.WriteLine("$" + total.ToString("0.00"));

            }
        }
        static void Problem4()
        {
            int x;
            int y;
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob04.in_.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() != -1)
                {
                    x = int.Parse(sr.ReadLine());
                    y = FactorialRecursion(x);
                    Console.WriteLine(y);
                }

            }

        }
        static int FactorialRecursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * FactorialRecursion(n - 1);
            }
        }
        static void Problem3()
        {
            int x = 0;
            string key = "";
            string coded = "";
            List<int> codedList = new List<int>();
            string decoded = "";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob03.in_.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                key += " ";
                key += sr.ReadLine();
                while (sr.Peek() != -1)
                {
                    coded += sr.Read().ToString(); ;                    
                }
                for (int i = 0; i < coded.Length; i++)
                {
                    x++;
                    if (coded[i] == '-')
                    {
                        for (int j = 0; j < x; j++)
                        {
                            codedList.Add(coded[i - x]);
                            
                            
                        }
                        x = 0;

                    }
                }
                
                for (int i = 0; i < coded.Length; i++)
                {
                    //decoded += key[];
                }
                Console.WriteLine(decoded);
            }
        }
    }
}
