using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAllDuplicateAndReverse
{
    internal class Program
    {
        static string removeAllDuplicateAndReverse(string str)
        {
            HashSet<char> list = new HashSet<char>();
            foreach(char elements in str)
            {
                list.Add(elements);
            }
            char [] str1 = list.ToArray();
            Array.Reverse(str1);
            return new string (str1);

        }
        static void Main(string[] args)
        {
            string str = "programming";
            string result = Program.removeAllDuplicateAndReverse(str);
            Console.WriteLine(result);
            Console.ReadLine(); 
        }
    }
}
