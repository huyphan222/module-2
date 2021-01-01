using System;

namespace BTDaoNguocPhanTuBangStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stackList = new MyStack(5);
            stackList.Push(2);
            stackList.Push(3);
            stackList.Push(5);
            stackList.Push(10);
            stackList.Push(12);            
            Console.WriteLine("1. Size of stack after push operations: " + stackList.Size());

            while (!stackList.IsEmpty())
            {
                Console.WriteLine(stackList.Pop());
            }

            Console.WriteLine("\n3. Size of stack after pop operations : " + stackList.Size());
         
            
        }
    }
}
