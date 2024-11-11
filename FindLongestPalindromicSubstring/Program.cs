//Find the Longest Palindromic Substring
// - Question: Write a function to find the longest palindromic substring in a given string.
// - Example: Input: "babad", Output: "bab" or "aba"

using System;

namespace FindLongestPalindromicSubstring
{
    internal class Program
    {
        static string findLongestPalindromSubstring(string str)
        {
            string str1 = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str1 += str[i];
            }
            return str1;
        }
        static void Main(string[] args)
        {
            string str = "babad";
            if (str1 == str)
            {

            }
            string result=Program.findLongestPalindromSubstring(str);
            Console.WriteLine(result);  
            Console.ReadLine(); 
        }
    }
}
