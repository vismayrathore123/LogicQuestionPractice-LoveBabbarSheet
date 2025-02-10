using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimalConversion
{
    public class Program
    {

        public static int binaryToDecimalConversion(int number)
        {
            int sum = 0;
            string binaryString = number.ToString();
          
            for (int i = 0; i<binaryString.Length; i++)
            {
                int digit = binaryString[binaryString.Length - 1 - i]-'0';
                
                sum += (digit) * (int)Math.Pow(2, i); ;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int number = 10011011;
            int result = Program.binaryToDecimalConversion(number);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
