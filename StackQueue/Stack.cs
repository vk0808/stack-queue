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
