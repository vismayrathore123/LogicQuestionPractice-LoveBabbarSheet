//Check Whether a Number is Even or Odd. 
// It’s an Even number is it’s perfectly divisible by 2 or an Odd number otherwise.

//Input: 4
//Output: Even

//Input: 7
//Output: Odd

//Input: 0
//Output: Even

//Input: -2
//Output: Even

//Input: -5
//Output: Odd

//Input: 1000001
//Output: Odd

//Input: 1000000
//Output: Even

//Input: -999
//Output: Odd

//Input: -1000
//Output: Even

//Input: 1
//Output: Odd

using System;

namespace CheckEvenOrOdd
{
    internal class Program
    {
        public static string checkEvenOrOdd(long n)
        {
            if (n % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        } 
        static void Main(string[] args)
        {
            long n = -1000001;
            string result= Program.checkEvenOrOdd(n);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
