//Given two arrays arr1 and arr2 of equal size, the task is to find whether the given arrays are equal. Two arrays are said to be equal if both contain the same set of elements, arrangements (or permutations) of elements may be different though.
//Note: If there are repetitions, then counts of repeated elements must also be the same for two arrays to be equal.
//Examples:
//Input: arr1[] = [1, 2, 5, 4, 0], arr2[] = [2, 4, 5, 0, 1]
//Output: true
//Explanation: Both the array can be rearranged to [0,1,2,4,5]
//Input: arr1[] = [1, 2, 5], arr2[] = [2, 4, 15]
//Output: false
//Explanation: arr1[] and arr2[] have only one common value.Given two arrays arr1 and arr2 of equal size, the task is to find whether the given arrays are equal. Two arrays are said to be equal if both contain the same set of elements, arrangements (or permutations) of elements may be different though.
//Note: If there are repetitions, then counts of repeated elements must also be the same for two arrays to be equal.
//Examples:
//Input: arr1[] = [1, 2, 5, 4, 0], arr2[] = [2, 4, 5, 0, 1]
//Output: true
//Explanation: Both the array can be rearranged to [0,1,2,4,5]
//Input: arr1[] = [1, 2, 5], arr2[] = [2, 4, 15]
//Output: false
//Explanation: arr1[] and arr2[] have only one common value.

using System;

namespace CheckEqualArray
{
    internal class Program
    {
        static bool isEqual(int[]arr, int [] arr1)
        {
            if (arr.Length != arr1.Length)
            {
                return false;
            }
            Array.Sort(arr);
            Array.Sort(arr1);
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr1[i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 4 };
            int[] arr1 = { 3, 3, 9, 9, 7 };
            bool result = Program.isEqual(arr, arr1);


            int[] arr3 = { 1, 2, 5, 4, 0 };
            int[] arr4 = { 2, 4, 5, 0, 1 };

            result = Program.isEqual(arr3, arr4);
            Console.WriteLine(result); 
            
            Console.ReadLine();

        }
    }
}
