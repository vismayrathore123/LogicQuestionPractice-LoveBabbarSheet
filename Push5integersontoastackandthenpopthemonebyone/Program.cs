using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Push 5 integers onto a stack and then pop them one by one.
namespace Push5integersontoastackandthenpopthemonebyone
{
    internal class Program
    {
        static void push(Stack<int> stack)
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);  
            stack.Push(4);
            stack.Push(5);


            Console.WriteLine("push 1,2,3,4,5");
        }
        static void popAll(Stack<int> stack)
        {
            while (stack.Count > 0)
            {
                int poppedElement = stack.Pop();
                Console.WriteLine("Popped element: " + poppedElement);
            }
        }
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            push(stack);
            popAll(stack); 
            Console.ReadLine();
        }
    }
}
