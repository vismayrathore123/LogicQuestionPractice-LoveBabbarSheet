using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfTwoStringAreAnagram
{
    internal class Program
    {
        public static bool checkIfTwoStringAreAnagram(string str, string str1)
        {
            if (str == null || str.Length == 0) { return false; }
            char[] charArray1= str.ToCharArray();
            char[] charArray2=str1.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            for (int i = 0; i < charArray1.Length; i++)
            {

                if (charArray1[i] != charArray2[i])
                {
                    return false;
                }

            }
            return true;
        }
       public static void Main(string[] args)
        {
            string str = "listen";
            string str1 = "silent";
          bool result= Program.checkIfTwoStringAreAnagram(str, str1);
            Console.WriteLine($"Are \"{str}\" and \"{str1}\" anagrams? {result}");
            Console.ReadLine();
        }
    }
}
