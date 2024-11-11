using System;
using System.Collections.Generic;

namespace CheckIfTheStackIsFull
{
    internal class Program
    {
        // Define maximum size of the stack
        static readonly int MAX_SIZE = 5;

        static void Push(Stack<int> stack, int item)
        {
            if (stack.Count >= MAX_SIZE)
            {
                Console.WriteLine("Stack is full. Cannot push more elements.");
            }
            else
            {
                stack.Push(item);
                Console.WriteLine($"Pushed {item} onto the stack.");
            }
        }

        static void FillStack(Stack<int> stack)
        {
            for (int i = 0; i < 7; i++)
            {
                Push(stack, i); // Try to push elements onto the stack
            }

            // Check final status
            if (stack.Count >= MAX_SIZE)
            {
                Console.WriteLine("Stack is full.");
            }
            else
            {
                Console.WriteLine("Can push more elements.");
            }
        }

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            FillStack(stack);
            Console.ReadLine();
        }
    }
}
