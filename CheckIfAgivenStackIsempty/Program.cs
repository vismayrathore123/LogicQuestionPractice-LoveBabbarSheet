using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfAgivenStackIsempty
{
    internal class Program
    {
        static void IsEmpty(Stack<int> stack)
        {
            bool isEmpty = stack.Count == 0;
            Console.WriteLine("Is the stack empty? " + isEmpty);
        }
        static void Main(string[] args)
        {
            Stack<int> stack=new Stack<int>();
            IsEmpty(stack);
            Console.ReadLine();
        }
    }
}
