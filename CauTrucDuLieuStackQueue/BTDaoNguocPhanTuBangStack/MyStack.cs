using System;

namespace BTDaoNguocPhanTuBangStack
{
    public class MyStack
    {
        private int[] arr;

        private int _size;

        private int index = 0;

        public MyStack(int size)
        {
            _size = size;
            arr = new int[size];
        }

        public bool IsEmpty()
        {
            if (index == 0)
            {
                return true;
            }
            return false;
        }

          public bool IsFull()
        {
            if (index == _size)
            {
                return true;
            }
            return false;
        }

        public int Size()
        {
            return index;
        }

         public void Push(int element)
        {
            if (IsFull())
            {
                throw new Exception("Stack is full");
            }
            arr[index] = element;
            index++;
        }

        public int Pop()
        {
            if(IsEmpty())
            {
                throw new Exception("Stack is full");
            }
            return arr[--index];
        }
    }
}