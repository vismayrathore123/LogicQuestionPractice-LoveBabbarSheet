//Given an integer num input as the upper limit, the objective is to sum up all the numbers that lay in the interval starting from 0 to the integer input “num”.
//Input: 5;
//Output: 15
//Explanation: 0 + 1 + 2 + 3 + 4 + 5 = 15

//Input: 10
//Output: 55
//Explanation: 0 + 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55

//Input: 0
//Output: 0
//Explanation: Sum of numbers from 0 to 0 is 0

//Input: 1
//Output: 1
//Explanation: 0 + 1 = 1

//Input: 3
//Output: 6
//Explanation: 0 + 1 + 2 + 3 = 6



using System;

namespace SumOfFirstNNaturalNumber
{
    internal class Program
    {
        static long sumOfFirstNNaturalNumber(long n)
        {
            long formula = (n * (n + 1)) / 2;
            return formula;
        }

        static void Main(string[] args)
        {
            long n = 5;
            long result = Program.sumOfFirstNNaturalNumber(n); 
            Console.WriteLine(result); 
            Console.ReadLine();
        }
    }
}
