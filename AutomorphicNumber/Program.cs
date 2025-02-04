using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomorphicNumber
{
    public class Program
    {
        public static bool automorphicNumber(int number)
        {
         
                int sq = number * number;
            
            while (number > 0)
            {
                if (number % 10 != sq % 10)
                {
                    return false;
                }
                number /= 10;
                sq /= 10;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int number = 25;
            bool result=Program.automorphicNumber(number);
            Console.WriteLine($"Is {number} an automorphic number? {result}");
        }
    }
}
