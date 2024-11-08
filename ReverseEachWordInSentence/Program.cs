//. Reverse Each Word in a Sentence
// - Question: Given a sentence, reverse each word in the sentence while keeping the word order the
//same.
// - Example: Input: "Hello World", Output: "olleH dlroW"


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEachWordInSentence
{
    internal class Program
    {
        public static string reverseEachWordInSentence(string str)
        {
            string[] words=str.Split(' ');  
            for(int i = 0; i<=words.Length-1; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i]=new string(charArray);
            }
            string output=string.Join("",words);
            return output;
        }
        static void Main(string[] args)
        {
            string str = "Hello World";
           string result= Program.reverseEachWordInSentence(str);
            Console.WriteLine(result +" ");
            Console.ReadLine();
        }
    }
}
