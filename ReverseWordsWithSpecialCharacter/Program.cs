
//Reverse Words with Special Characters
// - Question: Reverse only the words in a string while keeping special characters in their original
//positions.
// - Example: Input:"he!llo wo@rld", Output: "ol!leh dl@row"

//NOT COMPLETED YET

using System;
using System.Linq;

namespace ReverseWordsWithSpecialCharacter
{
    internal class Program
    {
        public static string reverseWordsWithSpecialCharacter(string str)
        {
            string[] words=str.Split(' ');
            for(int i=0;i<words.Length; i++)
            {
                char[] charArray=words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i]=new string(charArray);
            }
            string output=string.Join(" ", words);
            return output;
        }
            
        static void Main(string[] args)
        {
            string str= "he!llo wo@rld";
            string result = Program.reverseWordsWithSpecialCharacter(str);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
