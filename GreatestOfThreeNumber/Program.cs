using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestOfThreeNumber
{
    internal class Program
    {
        static int greatestOfThreeNumber(int a,int b,int c)
        {
            if(a>=b && a >= c)
            {
                Console.WriteLine("a is greater number");
                return a;
            }
            else if(b>=a && b >= c)
            {
                Console.WriteLine("b is greater number");
                return b;
            }
            else {
                Console.WriteLine("C is greater number");
                return c;
            }
        }

        static void Main(string[] args)
        {

            int a = 10,b=20,c=30;
            int result = Program.greatestOfThreeNumber(a, b, c);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
