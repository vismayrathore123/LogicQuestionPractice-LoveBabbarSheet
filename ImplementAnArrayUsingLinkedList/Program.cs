using System;
using System.Collections.Generic;

namespace ImplementStack
{
    internal class Program
    {
        // Push method to add elements to the stack
        static void Push(Stack<int> stack)
        {
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine("Pushed 10, 20, 30");
        }

        // Pop method to remove the top element from the stack
        static void Pop(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int poppedElement = stack.Pop();
                Console.WriteLine("Popped element: " + poppedElement);
            }
            else
            {
                Console.WriteLine("Stack is empty!");
            }
        }

        // Peek method to view the top element without removing it
        static void Peek(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int topElement = stack.Peek();
                Console.WriteLine("Peek: " + topElement);
            }
            else
            {
                Console.WriteLine("Stack is empty!");
            }
        }

        // Check if the stack is empty
        static void IsEmpty(Stack<int> stack)
        {
            bool isEmpty = stack.Count == 0;
            Console.WriteLine("Is the stack empty? " + isEmpty);
        }

        static void Main(string[] args)
        {
            // Create a stack
            Stack<int> stack = new Stack<int>();

            // Test the stack operations
            Push(stack);    // Push 10, 20, 30
            Pop(stack);     // Pop the top element (30)
            Peek(stack);    // Peek the top element (20)
            IsEmpty(stack); // Check if the stack is empty

            Console.ReadLine();
        }
    }
}
