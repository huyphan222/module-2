using System;

namespace ThQueueDungMang
{
    public class MyQueue
    {
        private int capacity;
        private int[] queueArr;

        private int head = 0;

        private int tail = -1;

        private int cureentlySize = 0;

        public MyQueue(int queueSize)
        {
            this.capacity = queueSize;
            queueArr = new int[this.capacity];
        }

        public bool IsQueueFull()
        {
            bool status = false;
            if (cureentlySize == 0)
            {
                status = true;
            }
            return status;    
        }

        public void Enqueue(int item)
        {
            if(IsQueueFull())
            {
                Console.WriteLine("Overflow ! Unable to add element: " + item);
            }
            else
            {
                tail++;
                if(tail == capacity - 1)
                {
                    tail = 0;
                }
                queueArr[tail] = item;
                cureentlySize++;
                Console.WriteLine("Element " + item + " is pushed to Queue !");
            }
        }

        public void  Dequeue()
        {
            if (IsQueueFull())
            {
                Console.WriteLine("Underflow ! Unable to remove element from Queue");
            }
            else
            {
                head++;
                if(head == capacity - 1)
                {
                     Console.WriteLine("Pop operation done ! removed: " + queueArr[head - 1]);
                    head = 0;
                }
                else
                {
                    Console.WriteLine("Pop operation done ! removed: " + queueArr[head - 1]);
                }
                cureentlySize--;
            }
        }
    }
}