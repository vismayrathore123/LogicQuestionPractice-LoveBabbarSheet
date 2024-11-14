

//Given an array arr of N integers, the task is to check whether the frequency of the elements in the array is unique or not. Or in other words, there are no two distinct numbers in array with equal frequency. If all the frequency is unique then return true, else return false.

//Example 1:

//Input:
//N = 5
//arr = [1, 1, 2, 5, 5]
//Output:
//false
//Explanation:
//The array contains 2 (1’s), 1 (2’s) and 2 (5’s), since the number of frequency of 1 and 5 are the same i.e. 2 times. Therefore, this array does not satisfy the condition.
//Example 2:

//Input:
//N = 10as
//arr = [2, 2, 5, 10, 1, 2, 10, 5, 10, 2]
//Output:
//true
//Explanation:
//Number of 1’s-> 1
//Number of 2’s -> 4
//Number of 5’s -> 2
//Number of 10’s -> 3.
//Since, the number of occurrences of elements present in the array is unique. Therefore, this array satisfy the condition.
using System;
using System.Collections.Generic;

namespace UniqueNumberOfOccurences
{
    internal class Program
    {
        public static bool isUniqueFrequency(int n, int[] arr)
        {
            Dictionary<int, int >dic = new Dictionary<int, int>();
            foreach(int num in arr)
            {
              if(dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic[num]= 1;
                }
            }
            HashSet<int> list = new HashSet<int>(); 
            foreach(var freq in dic.Values)
            {
                if (!list.Add(freq))
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 1, 2, 5, 5 };
            int[] arr2 = { 2, 2, 5, 10, 1, 2, 10, 5, 10, 2 };

            Console.WriteLine(isUniqueFrequency(arr1.Length, arr1));  
            Console.WriteLine(isUniqueFrequency(arr2.Length, arr2)); 
        }
            }
    }

