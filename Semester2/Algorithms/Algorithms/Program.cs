using System;
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
                Console.ReadKey();
            }
        }
        static void Problem2()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in_.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                int[]
                while (sr.Peek() > -1)
                {

                }

            }
        }
    }
}
