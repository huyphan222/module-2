using System;

namespace THTrienKhaiStackSuDungMang
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack(5);

            myStack.Push(5);
            myStack.Push(5);
            myStack.Push(4);
            myStack.Push(3);
            myStack.Push(1);

            Console.WriteLine("1. Size of stack after push operations: " + myStack.Size());
            Console.WriteLine("2. Pop elements from stack : ");

             while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop());
            }

            Console.WriteLine("\n3. Size of stack after pop operations : " + myStack.Size());
            
        }
    }
}
