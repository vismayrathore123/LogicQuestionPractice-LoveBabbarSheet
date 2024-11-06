using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_smallest
{
    internal class Program
    {
        public static void bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        
      
        static void Main(string[] args)
        {
            int[] arr = { 7, 10, 4, 3, 20, 15 };
            int k = 3;

            Program.bubbleSort(arr);
            if(k>0 && k <= arr.Length)
            {
                Console.WriteLine($"The {k}th smallest element is :{arr[k - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid value of k");
            }
            Console.ReadLine();
        }
    }
}
