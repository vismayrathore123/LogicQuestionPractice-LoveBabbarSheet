using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumAndMinimum
{
    internal class Program
    {
        public static Tuple<long,long> getMinMax(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            
            foreach(int num in arr)
            {
                if (num < min)
                {
                    min= num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            return Tuple.Create((long)min,(long)max);

        }
        static void Main(string[] args)
        {
            int [] arr =  { 3, 2, 1, 56 };
            var result = getMinMax(arr);
            Console.WriteLine("Minimum" + result.Item1 + ", Maximum" + result.Item2);
            Console.ReadLine();

        }
    }
}
