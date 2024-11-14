//usGiven three integers num1, num2 and num3 as inputs. The objective is to write a code to Find the Greatest of the Three 
//    Numbers in Java Language. To do so we’ll check the numbers with each other and print the largest of them all.
//Test Case 1
//Input: num1 = 10, num2 = 20, num3 = 30
//Explanation: Among 10, 20, and 30, the largest number is 30.
//Output: 30
//Test Case 2
//Input: num1 = -5, num2 = -10, num3 = -3
//Explanation: Among - 5, -10, and - 3, the largest number is -3.
//Output: -3
//Test Case 3
//Input: num1 = 50, num2 = 50, num3 = 20
//Explanation: Among 50, 50, and 20, the largest number is 50.
//Output: 50
//Test Case 4
//Input: num1 = 7, num2 = 7, num3 = 7
//Explanation: All three numbers are equal, so the largest number is 7.
//Output: 7
//Test Case 5
//Input: num1 = 100, num2 = 200, num3 = 150
//Explanation: Among 100, 200, and 150, the largest number is 200.
//Output: 200
//Test Case 6
//Input: num1 = 0, num2 = -1, num3 = 1
//Explanation: Among 0, -1, and 1, the largest number is 1.
//Output: 1
//Test Case 7
//Input: num1 = -15, num2 = -20, num3 = -10
//Explanation: Among - 15, -20, and - 10, the largest number is -10.
//Output: -10

using System;

namespace LargestOfThreeNumbers
{
    internal class Program
    {
        static void largestOfThreeNumbers(int number1, int number2, int number3)
        {
            if (number1 >= number2 && number1 >= number3)
            {
                Console.WriteLine("number1 is greatest");
            }else if(number2 >= number3 && number2 >= number1)
            {
                Console.WriteLine("number2 is greatest");
            }else
            {
                Console.WriteLine("Number3 is greatest");
            }
        }
        static void Main(string[] args)
        {
            int number1 = -15;
            int number2 = -20;
            int number3 = -10;

           largestOfThreeNumbers(number1, number2, number3);
            Console.ReadLine(); 


        }
    }
}
