using System;
using System.Collections.Generic;

namespace HexaToDecimalConversion
{
    public class Program
    {
        public static int HexaToDecimalConversion(string hexaDecimal)
        {
            int sum = 0;

            // Corrected dictionary structure
            var conversion = new Dictionary<char, int>
            {
                { '0', 0 }, { '1', 1 }, { '2', 2 }, { '3', 3 },
                { '4', 4 }, { '5', 5 }, { '6', 6 }, { '7', 7 },
                { '8', 8 }, { '9', 9 }, { 'A', 10 }, { 'B', 11 },
                { 'C', 12 }, { 'D', 13 }, { 'E', 14 }, { 'F', 15 }
            };

            hexaDecimal = hexaDecimal.ToUpper();

            for (int i = 0; i < hexaDecimal.Length; i++)
            {
                char currentChar = hexaDecimal[hexaDecimal.Length - i - 1];

                if (!conversion.ContainsKey(currentChar))
                {
                    throw new ArgumentException("Invalid hexadecimal character.");
                }

                int digit = conversion[currentChar];
                sum += digit * (int)Math.Pow(16, i);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            string hexaDecimal = "7CF";
            int result = HexaToDecimalConversion(hexaDecimal);
            Console.WriteLine($"Decimal number is {result}");
        }
    }
}
