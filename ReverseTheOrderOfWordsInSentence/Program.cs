//Reverse the Order of Words in a Sentence
// - Question: Reverse the order of words in a sentence.
 //- Example: Input: "The quick brown fox", Output: "fox brown quick The"


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTheOrderOfWordsInSentence
{
    internal class Program
    {
        public static string reverseTheOrderOfWordInSentence(string str)
        {
            string[] words = str.Split(' ');
        Array.Reverse(words);
            return string.Join(" ", words); 
        }
        static void Main(string[] args)
        {
            string str = "The quick brown fox";
            string result= Program.reverseTheOrderOfWordInSentence(str);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
