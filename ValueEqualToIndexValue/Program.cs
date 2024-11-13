//Given an array arr. Your task is to find the elements whose value is equal to that of its index value ( Consider 1-based indexing ).

//Note: There can be more than one element in the array which have the same value as its index. You need to include every such element's index. Follows 1-based indexing of the array.

//Examples:

//Input: arr[] = [15, 2, 45, 4, 7]
//Output: 2 , 4
//Explanation:
//Here, arr[2] = 2 exists here.
//and arr[4] = 4 exists here.
//Input: arr[] = [1]
//Output: 1
//Explanation: Here arr[1] = 1 exists.
using System;
using System.Collections.Generic;

namespace ValueEqualToIndexValue
{
    internal class Program
    {
        static List<int> valueEqualToIndex(List<int> arr)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == i + 1)  
                {
                    result.Add(i + 1);  
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 15, 2, 45, 4, 7 };
            List<int> result = Program.valueEqualToIndex(arr);
            Console.WriteLine(string.Join(", ", result));
            Console.ReadLine();
        }
    }
}
