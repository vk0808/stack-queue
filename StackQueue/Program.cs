using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program\n");

            Stack stack = new Stack();

            stack.Push(70);
            stack.Display();

            stack.Push(30);
            stack.Display();

            stack.Push(56);
            stack.Display();
        }
    }
}
