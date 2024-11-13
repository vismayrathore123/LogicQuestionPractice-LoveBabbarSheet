//Given an array A of size N. The elements of the array consist of positive integers. You have to find the largest element with minimum frequency.

//Example 1:

//Input:
//5
//2 2 5 50 1
//Output:
//50
//Explanation:
//All elements are having frequency 1 except 2.
//50 is the maximum element with minimum frequency.
//Example 2:

//Input:
//4
//3 3 5 5
//Output:
//5
//Explanation:
//Both 3 and 5 have the same frequency, so 5 should be returned

using System;
using System.Collections.Generic;

namespace FrequencyGame
{
    internal class Program
    {
        public static int largButMinFreq(int[] arr, int n)
        {
            // Dictionary to store the frequency of each element
            Dictionary<int, int> dic = new Dictionary<int, int>();

            // Count the frequency of each element in the array
            foreach (int num in arr)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic[num] = 1;
                }
            }

            // Find the minimum frequency
            int minFrequency = int.MaxValue;
            foreach (var freq in dic.Values)
            {
                if (freq < minFrequency)
                {
                    minFrequency = freq;
                }
            }

            // Find the largest element with the minimum frequency
            int result = int.MinValue;
            foreach (var pair in dic)
            {
                if (pair.Value == minFrequency && pair.Key > result)
                {
                    result = pair.Key;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Example 1: Elements with different frequencies
            int[] arr1 = { 2, 2, 5, 50, 1 };
            Console.WriteLine(largButMinFreq(arr1, arr1.Length)); // Output: 50

            // Example 2: Elements with the same frequency
            int[] arr2 = { 3, 3, 5, 5 };
            Console.WriteLine(largButMinFreq(arr2, arr2.Length)); // Output: 5

            Console.ReadLine();
        }
    }
}
