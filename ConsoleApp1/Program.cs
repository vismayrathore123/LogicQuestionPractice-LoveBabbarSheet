
//Given an 0-indexed array of integers arr[], find its peak element and return its index. An element is considered to be peak if its value is greater than or equal to the values of its adjacent elements (if they exist).

//Note: The output will be "true" if the index returned by your function is correct; otherwise, it will be "false".
namespace PeakElement
{
    using System;

    namespace PeakElement
    {
        internal class Program
        {
            public static int FindPeakElement(int[] arr)
            {
                int n = arr.Length;

                
                if (n == 1)
                    return 0;

               
                if (arr[0] >= arr[1])
                    return 0;

          
                if (arr[n - 1] >= arr[n - 2])
                    return n - 1;

           
                for (int i = 1; i < n - 1; i++)
                {
                    if (arr[i] >= arr[i - 1] && arr[i] >= arr[i + 1])
                        return i;
                }

                return -1;
            }

            static void Main(string[] args)
            {
                // Test case 1
                int[] arr1 = { 1, 2, 3 };
                int peakIndex1 = FindPeakElement(arr1);
                Console.WriteLine("Peak Index for arr1: " + peakIndex1);

                // Test case 2
                int[] arr2 = { 1, 1, 1, 2, 1, 1, 1 };
                int peakIndex2 = FindPeakElement(arr2);
                Console.WriteLine("Peak Index for arr2: " + peakIndex2); 

                // Test case 3
                int[] arr3 = { 1, 1, 1 };
                int peakIndex3 = FindPeakElement(arr3);
                Console.WriteLine("Peak Index for arr3: " + peakIndex3);
                Console.ReadLine();
            }
        }
    }

}
