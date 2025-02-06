using System;

namespace FriendlyPair
{
    public class Program
    {
        static int SumOfDivisors(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static bool IsFriendlyPair(int num1, int num2)
        {
            int sum1 = SumOfDivisors(num1);
            int sum2 = SumOfDivisors(num2);

            return (sum1 / num1 == sum2 / num2);
        }

        static void Main(string[] args)
        {
            int num1 = 6;
            int num2 = 28;

            if (IsFriendlyPair(num1, num2))
            {
                Console.WriteLine($"Yes, numbers {num1} and {num2} are friendly pairs.");
            }
            else
            {
                Console.WriteLine($"No, numbers {num1} and {num2} are not friendly pairs.");
            }
            Console.ReadLine();
        }
    }
}
