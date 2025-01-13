using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);

        Console.WriteLine("Reversed number: " + reversedNumber);
    }

    // Recursive method to reverse the number
    static int ReverseNumber(int num)
    {
        if (num == 0)
        {
            return 0;
        }
        else
        {
            return (num % 10) * (int)Math.Pow(10, (int)Math.Log10(num)) + ReverseNumber(num / 10);
        }
    }
}
