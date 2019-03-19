using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(1234);
            List<int> list = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(rand.Next(0, 1000));
            }
            list.Sort();
            Console.WriteLine(SearchSortedList(list, 47, 1000, 0));
            Console.ReadKey();
        }
        static bool SearchSortedList( List<int> list, int n, int upperBound, int lowerBound)
        {
            int guess = lowerBound + (upperBound - lowerBound) / 2;

            if (list[guess] == n)
            {
                return true;
            }
            else if (list[guess] < n)
            {
                lowerBound = guess;
            }
            else if (list[guess] > n)
            {
                upperBound = guess;
            }
            if (upperBound - lowerBound < 2)
                return false;
            return SearchSortedList(list, n, upperBound, lowerBound);
        }
       
    }
}
