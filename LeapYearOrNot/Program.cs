using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearOrNot
{
    internal class Program
    {
        static bool leapYearOrNot(int year)
        {
            if((year%4==0 && year % 100 != 0) || (year%400==0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int year = 2015;
            bool result= Program.leapYearOrNot(year);
            if (result)
            {
                Console.WriteLine($"{year}: it is leap");
            }
            else
            {
                Console.WriteLine($"{year}: not leap");
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
