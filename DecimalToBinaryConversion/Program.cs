using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryConversion
{
    public class Program
    {
        public static string decimalToBinaryConversion(int decimalNumber)
        {
            string binary = "";
            while (decimalNumber > 0) { 
            int remainder = decimalNumber % 2;
            binary = remainder + binary;
            decimalNumber /= 2;

        }
         return binary;
            }
        static void Main(string[] args)
        {
            int decimalNumber = 294;
            string result = Program.decimalToBinaryConversion(decimalNumber);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
