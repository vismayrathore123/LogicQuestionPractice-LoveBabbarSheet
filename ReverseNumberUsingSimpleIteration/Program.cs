using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberUsingSimpleIteration
{
    public class Program
    {
        public void reverseNumber(int[] arr)
        {
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]+ " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
           
            Program prgrm = new Program();
            int[] arr = { 1, 2, 3, 4, 5 };
          prgrm.reverseNumber(arr);
           
            Console.ReadLine();
        }
    }
}
