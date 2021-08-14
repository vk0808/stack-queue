using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public class Queue
    {
        Node head = null;

        // method to add data to queue
        public void Enqueue(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"{node.data} appended into queue ");
        }

        // method to remove data from queue 
        public void Dequeue()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.WriteLine($"Dequeue : {this.head.data}");
            this.head = this.head.next;
        }

        // Remove all until queue is Empty
        public void Empty()
        {
            while (this.head != null)
            {
                Dequeue();
                Display();
            }
        }

        // method to display queue
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }

    }
}
