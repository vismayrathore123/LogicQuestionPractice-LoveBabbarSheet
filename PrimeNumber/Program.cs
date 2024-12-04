using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static bool primeNumber(int number)
        {
            if (number < 1)
            {
                return false;
            }
            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int number = 4;
            bool result= Program.primeNumber(number);
            if (result)
            {
                Console.WriteLine($"{result} is a prime");
            }
            else {
                Console.WriteLine($"{result} is not a prime ");
            }
            Console.WriteLine(number);

        }
    }
}
