using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

//You are given an array A of size N. The array contains almost distinct elements with some duplicated. You have to print the elements in sorted order which appears more than once.

//Input Format:
//The first line of input contains T, denoting the number of testcases. T testcases follow. Each testcase contains two lines of input.  The first line of input contains size of array N. The second line contains N integers separated by spaces.

//Output Format:
//For each test case, in a new line, print the required answer. If there are no duplicates print -1.

//Your Task:
//Your task is to complete the function SortedDuplicates(arr, n) which accepts array and its size as an argument.

namespace DuplicateElements
{
    internal class Program
    {
        
            
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 2, 4, 3, 5 };
            HashSet<int> set = new HashSet<int>(list);
            List<int> result=new List<int>(set);

            foreach (int i in result) { 
            Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
