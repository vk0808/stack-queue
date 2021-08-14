using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program\n");

            //Stack stack = new Stack();

            //stack.Push(70);
            //stack.Display();

            //stack.Push(30);
            //stack.Display();

            //stack.Push(56);
            //stack.Display();

            //stack.Empty();

            Queue queue = new Queue();

            queue.Enqueue(56);
            queue.Display();

            queue.Enqueue(30);
            queue.Display();

            queue.Enqueue(70);
            queue.Display();

            queue.Empty();
        }
    }
}
