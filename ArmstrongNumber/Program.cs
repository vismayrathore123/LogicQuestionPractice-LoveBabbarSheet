using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    internal class Program
    {
        static bool isArmstrong(int n)
        {
            int originalNumber = n;
            int r, armstrongNumber = 0;
            while (n > 0)
            {
                r = n % 10;
                armstrongNumber = armstrongNumber + (r * r * r);
                n = n / 10;
            }
            return (armstrongNumber == originalNumber);

        }
        static void Main(string[] args)
        {
            int n = 441;
            bool result = isArmstrong(n);
            if (result)
            {
                Console.WriteLine($"{n} is a armstrong number");
            }
            else
            {
                Console.WriteLine($"{n} is not a armstrong number");
            }
            Console.ReadLine();
        }
        
    }
}
