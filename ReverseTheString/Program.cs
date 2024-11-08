using System;

namespace ReverseTheString
{
    internal class Program
    {
        public static string ReverseTheString(string str)
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
            string str = "Evision Software Solution";
            string result = Program.ReverseTheString(str); 
            Console.WriteLine("Reversed string is: " + result);
            Console.ReadLine();
        }
    }
}
