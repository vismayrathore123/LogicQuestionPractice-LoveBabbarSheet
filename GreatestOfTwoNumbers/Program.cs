//Given two integer input Number1 and Number2, the objective is to write a Java code to compare both the Numbers and 
// Find the Greatest of the Two Numbers. 
//Enter the first number (Number1): 10
//Enter the second number (Number2): 20
//The greatest number is: 20


//    Enter the first number (Number1): -5
//Enter the second number (Number2): 5
//The greatest number is: 5


using System;

namespace GreatestOfTwoNumbers
{
    internal class Program
    {
        static void greatestOfTwoNumbers(int number1, int number2)
        {
            if (number1 > number2)
            {

                Console.WriteLine("greatest number is :" + number1);
            }
            else if (number1 == number2)
            {
                Console.WriteLine("numbers are equal"  );
            }
            else
            {
                Console.WriteLine("number2 is greatest");
            }

        }
        static void Main(string[] args)
        {
            int number1 =-5;
                int number2 =5;
            Program.greatestOfTwoNumbers(number1, number2);  
          
            Console.ReadLine();
        }
    }
}
