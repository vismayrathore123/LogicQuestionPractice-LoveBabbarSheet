using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_0s_1s_2s
{
    internal class Program
    {
        public static void   sort_0s_1s_2s(int [] arr)
        {
          Array.Sort(arr);
        }
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
           Program.sort_0s_1s_2s(arr);
            Console.WriteLine("Sorted Array");
            foreach(int num in arr)
            {
                Console.Write(num +"");
            }
            Console.ReadLine();
           
        }
    }
}
