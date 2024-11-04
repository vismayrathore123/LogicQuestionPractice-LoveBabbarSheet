using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Array.Reverse(arr);
            Console.WriteLine(string.Join(",", arr));
            Console.ReadLine();
            
        }
    }
}
