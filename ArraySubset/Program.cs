
//Given two arrays: a1[0..n-1] of size n and a2[0..m-1] of size m, where both arrays may contain duplicate elements. The task is to determine whether array a2 is a subset of array a1. It's important to note that both arrays can be sorted or unsorted. Additionally, each occurrence of a duplicate element within an array is considered as a separate element of the set.
//Example 1:
//Input:
//a1[] = {11, 7, 1, 13, 21, 3, 7, 3}
//a2[] = {11, 3, 7, 1, 7}
//Output:
//Yes
//Explanation:
//a2[] is a subset of a1[]Given two arrays: a1[0..n-1] of size n and a2[0..m-1] of size m, where both arrays may contain duplicate elements. The task is to determine whether array a2 is a subset of array a1. It's important to note that both arrays can be sorted or unsorted. Additionally, each occurrence of a duplicate element within an array is considered as a separate element of the set.
//Example 1:
//Input:
//a1[] = {11, 7, 1, 13, 21, 3, 7, 3}
//a2[] = {11, 3, 7, 1, 7}
//Output:
//Yes
//Explanation:
//a2[] is a subset of a1[]

using System;
using System.Collections.Generic;

namespace ArraySubset
{
    internal class Program
    {
        static string arraySubset(int[]a1, int[] a2)
        {
            List<int> list=new List<int>(a1);
            foreach(int element in a2)
            {
                if (list.Contains(element))
                {
                    list.Remove(element);
                }
                else
                {
                    return "No";
                }
            }
            return "yes";
        }
        static void Main(string[] args)
        {
            int []a1 = { 11, 7, 1, 13, 21, 3, 7, 3 };
            int []a2 = { 11, 3, 7, 1, 7 };
            string  result=Program.arraySubset(a1, a2); 
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
