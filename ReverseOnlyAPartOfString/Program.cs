//Reverse Only a Part of a String
// - Question: Given a string and two indices start and end, reverse only the substring between these
//indices.
// - Example: Input: str = "abcdef", start = 1, end = 4, Output: "aedcbf"


using System;
namespace ReverseOnlyAPartOfString
{
    internal class Program
    {
        static string partOfString(string str,int start,int end) 
        {
            char[] chars    =str.ToCharArray();
            while (start < end)
            {
                char temp= chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
                start++;
                end--;
            }
            return new string(chars);
        }
        static void Main(string[] args)
        {
            string str = "openai";
            int start = 0;
            int end = 3;
            string result= Program.partOfString(str,start,end);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
