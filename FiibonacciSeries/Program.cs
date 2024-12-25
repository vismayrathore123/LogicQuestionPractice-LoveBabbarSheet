using System;

namespace FibonacciSeries
{
    internal class Program
    {
        static void PrintFibonacciSeries(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            int previous = 0, current = 1;

            Console.Write("Fibonacci Series: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(previous + " ");
                int next = previous + current;
                previous = current;
                current = next;
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms in the Fibonacci series: ");
            int n = int.Parse(Console.ReadLine());

            PrintFibonacciSeries(n);
            Console.ReadLine();
        }
    }
}
