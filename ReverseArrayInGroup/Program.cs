//Given an array arr of positive integers. Reverse every sub-array group of size k.

//Note: If at any instance, k is greater or equal to the array size, then reverse the entire array. You shouldn't return any array, modify the given array in place.

//Examples:

//Input: k = 3, arr = [1, 2, 3, 4, 5]
//Output: [3, 2, 1, 5, 4]
//Explanation: First group consists of elements 1, 2, 3. Second group consists of 4,5.
//Input: k = 5, arr = [5, 6, 8, 9]
//Output: [9, 8, 6, 5]
//Explnation: Since k is greater than array size, the entire array is reversed.


using System;
using System.Collections.Generic;

namespace ReverseArrayInGroup
{
    internal class Program
    {
        
        void ReverseArrayInGroup(List<int> arr, int k)
        {
           
            if (k >= arr.Count)
            {
                arr.Reverse();
                return;
            }

           
            for (int i = 0; i < arr.Count; i += k)
            {
               
                int left = i;
                int right = Math.Min(i + k - 1, arr.Count - 1);

                while (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    left++;
                    right--;
                }
            }
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 2, 3, 4, 5 };
            int k = 3;

            Program program = new Program();
            program.ReverseArrayInGroup(arr, k);

         
            Console.WriteLine(string.Join(", ", arr));
            Console.ReadLine();
        }
    }
}
