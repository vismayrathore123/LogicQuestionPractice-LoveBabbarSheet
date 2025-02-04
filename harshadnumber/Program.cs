using System;

namespace HarshadNumber
{
    public class Program
    {
        static bool harshadNumber(int number)
        {
            int sum = 0;
            int originalNumber = number;

            // Check if the number is positive
            if (number <= 0)
            {
                return false; // Harshad numbers are generally considered for positive integers
            }

            // Calculate the sum of digits
            while (number > 0)
            {
                sum += number % 10;  // Add the last digit to sum
                number /= 10;         // Remove the last digit
            }

            // Check if the original number is divisible by the sum of its digits
            return originalNumber % sum == 0;
        }

        static void Main(string[] args)
        {
            int number = 18;
            bool result = Program.harshadNumber(number);
            Console.WriteLine($"Is {number} a Harshad number? {result}");
        }
    }
}
