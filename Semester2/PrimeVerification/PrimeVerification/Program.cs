using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckForPrime(27427));
            Console.ReadKey();
        }
        static bool CheckForPrime(int n, int divisor = 2)
        {
           
            
            if (n % divisor == 0)
            {
                return false;
            }
            else if (divisor > n/2)
            {
                return true;
            }
            else
            {
                return CheckForPrime(n, divisor + 1);
            }

        }
    }
}
