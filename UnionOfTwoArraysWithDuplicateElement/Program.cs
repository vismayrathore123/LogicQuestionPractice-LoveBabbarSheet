using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionOfTwoArraysWithDuplicateElement
{
    internal class Program
    {
       public static int findUnion(int [] a, int []b)
        {
            HashSet<int> obj= new HashSet<int> ();
          
            for(int i = 0; i < a.Length; i++)
            {
               obj.Add (a [i]);
            }
            for(int i = 0; i < b.Length; i++)
            {
                obj.Add(b [i]);
            }


            return obj.Count;
        }
        static void Main(string[] args)
        {
            int [] a = { 85, 25, 1, 32, 54, 6, 2 };
            int[] b = { 85, 2 };
            
           int count= Program.findUnion(a,b);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
