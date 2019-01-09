using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            List<int> myList = new List<int>();
            int n = 0;
                        
            while (n < 10)
            {
                
                Console.WriteLine("input number");
                int user = int.Parse(Console.ReadLine());
                myArray[n] = user;
                n++;                                
            }
            //resets array position
            n = 0;
            Console.WriteLine("Your Array");
            while (n < 10) 
            {                              
                Console.WriteLine(myArray[n]);              
                
                // keeps track of array position and the while loop
                n++;

            }
            Console.ReadKey();
        }

    }
}
