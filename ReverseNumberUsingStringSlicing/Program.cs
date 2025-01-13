using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberUsingStringSlicing
{
    public class Program
    {
        static int reverseNumber(int number)
        {
            string numString = number.ToString();
            string reversedString = new string(numString.Reverse().ToArray());
            return int.Parse(reversedString);
        }
        static void Main(string[] args)
        {
            int originalNumber = 12345;
            int reversNumber = reverseNumber(originalNumber);
            Console.WriteLine($"Reversed Number is :{ reversNumber}");


        }
    }
}
