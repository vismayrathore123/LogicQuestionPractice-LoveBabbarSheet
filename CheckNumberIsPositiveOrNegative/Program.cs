//check whether the number entered by the user is positive or negative. The number is demonstrated as positive or negative by comparing the entered number with the Zero(0). If the number entered by the user is greater than zero, then the number is positive, else if the number is less than zero, then the number is negative and else the number is zero.

//N > 0 then, number is Positive.
//N < 0 then, number is Negative.
//N = 0 then, number is Zero.

//Input: 5
//Output: Positive

//Input: -3
//Output: Negative

//Input: 0
//Output: Zero

//Input: 1
//Output: Positive

//Input: -1
//Output: Negative

//Input: 1000000
//Output: Positive

//Input: -1000000
//Output: Negative

//Input: 0.0001
//Output: Positive

//Input: -0.0001
//Output: Negative

//Input: -0.0
//Output: Zero

using System;

namespace CheckNumberIsPositiveOrNegative
{
    internal class Program
    {
        public static string checkNumberIsPositiveOrNegative(double n)
        {
            if(n< 0)
            {
                return "neagtive" ;
            }
            return "positive";
        }
        static void Main(string[] args)
        {
            double n = -0.0001;
            string result = Program.checkNumberIsPositiveOrNegative(n);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
