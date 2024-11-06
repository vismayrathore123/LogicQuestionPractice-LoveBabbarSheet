using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveAllNegativeElementToOneSideOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -12, -13, -5, -7, -3, -6, 11, 6, 5 };
            Array.Sort(arr);
            Console.WriteLine("Sorted Array");
            foreach(int num in arr)
            {
                Console.WriteLine(num+" ");
            }
            Console.ReadLine();
        }
    }
}
