using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public class Stack
    {
        // instance variable
        public Node top;


        // constructor
        public Stack()
        {
            this.top = null;
        }

        // method to push
        public void Push(int data)
        {
            Node node = new Node(data);

            node.next = this.top;
            this.top = node;
        }

        // method to check if stack is empty
        public bool IsEmpty()
        {
            return this.top == null;
        }

        // method to get first node data 
        public void Peek()
        {
            // check for empty stack
            if (!IsEmpty())
            {
                Console.WriteLine($"Peek: {this.top.data}");
            }
            else
            {
                Console.WriteLine("Stack is empty\n");
            }
        }

        // method to remove at the beginning
        public void Pop() 
        {
            // check for stack empty
            if (this.top == null)
            {
                Console.Write("Stack is empty\n");
                return;
            }

            // update the top pointer and point it to next node
            this.top = this.top.next;
        }


        public void Empty()
        {
            while (!IsEmpty())
            {
                Peek();
                Pop();
                Display();
            }
        }


        // method to display
        public void Display()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            Console.WriteLine("\n");
        }

    }
}
