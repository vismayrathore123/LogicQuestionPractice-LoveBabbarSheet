using System;

namespace ImplementingStackUsingLinkedList
{
    class Program
    {
        // Define the Node class
        class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }

        // Define the Stack class
        class Stack
        {
            public Node head; // This will be the top of the stack

            // Check if the stack is empty
            public bool isEmpty()
            {
                return head == null;
            }

            // Push a new item onto the stack
            public void push(int data)
            {
                Node newNode = new Node(data); // Create a new node
                if (isEmpty())
                {
                    head = newNode; // If stack is empty, the new node is the head
                }
                else
                {
                    newNode.next = head; // Point new node to current head
                    head = newNode; // Move head to new node
                }
            }

            // Pop the top item from the stack
            public int pop()
            {
                if (isEmpty())
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                int poppedValue = head.data; // Get the data of the top node
                head = head.next; // Move head to the next node
                return poppedValue; // Return the data
            }

            // Peek at the top item without removing it
            public int peek()
            {
                if (isEmpty())
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                return head.data; // Return the data of the top node
            }
        }

        static void Main(string[] args)
        {
            // Create a stack
            Stack stack = new Stack();

            // Push some values onto the stack
            stack.push(10);
            stack.push(20);
            stack.push(30);

            // Peek at the top value
            Console.WriteLine("Top value is: " + stack.peek());

            // Pop values from the stack
            Console.WriteLine("Popped value is: " + stack.pop());
            Console.WriteLine("Popped value is: " + stack.pop());

            // Peek after popping
            Console.WriteLine("Top value after popping: " + stack.peek());
        }
    }
}
