
//Reverse the String Without Using Additional Space
// - Question: Reverse a string in place (modifying the original string) without using extra space.
// -Example: Input: "hello", Output: "olleh"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringWithoutExtraSpace
{
    internal class Program
    {
        public static string reverseStringWithoutExtraSpace(string str)
        {
            string[] words=str.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                char[] charArray=words[i].ToCharArray();
                Arra
            }
        }
        static void Main(string[] args)
        {
            string str = "hello world";
            string result = Program.reverseStringWithoutExtraSpace(str);
            Console.WriteLine(result);  
            Console.ReadLine();
        }
    }
}
