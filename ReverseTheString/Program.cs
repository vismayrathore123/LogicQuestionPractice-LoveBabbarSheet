using System;

namespace ReverseTheString
{
    internal class Program
    {
        public static string ReverseTheString(string str)
        {
            // Convert the string to a character array since strings are immutable in C#
            char[] charArray = str.ToCharArray();

            int left = 0;
            int right = charArray.Length - 1;

            // Swap the characters from both ends towards the center
            while (left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;

                left++;
                right--;
            }

            // Return the new reversed string
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            string str = "The quick brown fox";
            string result = Program.ReverseTheString(str);
            Console.WriteLine("Reversed string is: " + result);
            Console.ReadLine();
        }
    }
}
