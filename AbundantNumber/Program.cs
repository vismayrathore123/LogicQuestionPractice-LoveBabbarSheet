using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbundantNumber
{
    public class Program
    {
        
        static bool isAbundant(int number)
        {
            int sum = 0;
            for (int i =0; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum > number;
        }
        static void Main(string[] args)
        {
            int number = 12;
            if (isAbundant(number))
            {
                Console.WriteLine($"number is redundant{number}");
            }
            else
            {
                Console.WriteLine($"number is not abundant{number}");
            }
            Console.ReadLine();
        }

    }
}
