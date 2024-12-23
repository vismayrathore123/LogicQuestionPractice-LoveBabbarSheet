using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    public class Program
    {
        static bool isPalindrome(int n)
        {
            int originalNumber = n;
            int reversedNumber = 0;
            int remainder;
            while (n != 0)
            {
                remainder = n % 10;
                reversedNumber= reversedNumber*10+remainder;
                n /= 10;
            }
            return (reversedNumber == originalNumber);
        }
        static void Main(string[] args)
        {
            int n = 221;
            bool result= isPalindrome(n);
            if (result) {
                Console.WriteLine($"{n} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{n} it is not palindrome");
            }
            
            Console.ReadLine();
        }

    }
}
