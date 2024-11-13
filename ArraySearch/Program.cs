﻿using System;
using System.Security.Policy;

//Given an array, arr of n integers, and an integer element x, find whether element x is present in the array. Return the index of the first occurrence of x in the array, or -1 if it doesn't exist.

//Examples:

//Input: arr[] = [1, 2, 3, 4], x = 3
//Output: 2
//Explanation: There is one test case with array as [1, 2, 3 4] and element to be searched as 3.Since 3 is present at index 2, the output is 2.
//Input: arr[] = [10, 8, 30, 4, 5], x = 5
//Output: 4
//Explanation: For array[1, 2, 3, 4, 5], the element to be searched is 5 and it is at index 4.So, the output is 4.
namespace ArraySearch
{
    internal class Program
    {
        static int search(int []arr, int x)
        {
            
            for(int i = 0; i <= arr.Length; i++)
            {
                if (arr[i]== x)
                {
                    return i;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int x = 3;
            int result=Program.search(arr, x);
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
