using System;

namespace CauTrucDuLieuStackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedListQueue queue = new MyLinkedListQueue();
            queue.Enqueue(10);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            queue.Enqueue(20);
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(30);
            queue.Enqueue(40);
           
            Console.WriteLine("Dequeued item is " + queue.Dequeue().key);
        }
    }
}
