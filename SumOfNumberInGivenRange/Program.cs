//using System;
//Given the range as integer input, the objective is to find the Sum of all the Numbers that lay in the given interval using different methods. 
//    To do so we basically iterate from the base interval to the final interval and keep adding the number.

//Test Case 1
//Input: start = 1, end = 5

//Explanation: The numbers in the range are 1, 2, 3, 4, 5. The sum is:

//1
//+
//2
//+
//3
//+
//4
//+
//5
//=
//15
//1 + 2 + 3 + 4 + 5 = 15
//Output: 15

//Test Case 2
//Input: start = 3, end = 7

//Explanation: The numbers in the range are 3, 4, 5, 6, 7. The sum is:

//3
//+
//4
//+
//5
//+
//6
//+
//7
//=
//25
//3 + 4 + 5 + 6 + 7 = 25
//Output: 25

//Test Case 3
//Input: start = 0, end = 10

//Explanation: The numbers in the range are 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10. The sum is:

//0
//+
//1
//+
//2
//+
//3
//+
//4
//+
//5
//+
//6
//+
//7
//+
//8
//+
//9
//+
//10
//=
//55
//0 + 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55
using System;

namespace SumOfNumberInGivenRange
{
    internal class Program

    {
        public static int sumOfNumberInGivenRange(int start, int end)
        {
            int sum = 0;
            for(int i=start;i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int start = 0;
            int end = 10;
            int result= Program.sumOfNumberInGivenRange(start, end);
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
