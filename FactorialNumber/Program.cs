using System;

namespace FactorialNumber
{
    internal class Program
    {
        static int factorialNumber(int n)
        {
            int res = 1; 

            if (n == 0) return 1; 
            for (int i = 2; i <= n; i++) 
            {
                res *= i; 
            }

            return res; 































































































        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(factorialNumber(n)); // Print the factorial of n

            Console.ReadLine(); // Wait for user input before exiting
        }
    }
}
