using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayByOne
{
    internal class Program
    {
        public static void rotateArray(int[] a)
        {
            int n=a.Length;
            int last = a[n-1];
            for(int i=4;i>0;i--)
            {
                a[i] = a[i - 1];
            }
            a[0] = last;
            Console.WriteLine("Rotated array is:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
             Program.rotateArray(a);
            

        }
    }
}
