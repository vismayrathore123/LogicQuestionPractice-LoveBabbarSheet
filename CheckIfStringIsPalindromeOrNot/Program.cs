using System;

namespace CheckIfStringIsPalindromeOrNot
{
    internal class Program
    {
        static string ReverseString(string str)
        {
            string reversedStr = "";
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                reversedStr += str[i];
            }
            return reversedStr;
        }

        static void Main(string[] args)
        {
            string str = "madam";
            if (ReverseString(str) == str)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
