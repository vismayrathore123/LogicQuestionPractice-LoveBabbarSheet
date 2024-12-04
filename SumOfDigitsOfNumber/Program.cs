using System;

namespace SumOfDigitsOfNumber
{
    internal class Program
    {
        static int SumOfDigitsOfNumber(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10; 
                number /= 10;       
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int number = 1234;
            int result = Program.SumOfDigitsOfNumber(number);
            Console.WriteLine("The sum of the digits of the number is: " + result);
            Console.ReadLine();
        }
    }
}
