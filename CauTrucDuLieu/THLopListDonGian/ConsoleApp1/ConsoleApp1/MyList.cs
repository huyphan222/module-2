using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
    class MyList<T>
    {
        private int Capacity { get; set; }
        private Object[] Items;
        public MyList()
        {
            Items = new Object[10];
        }

        public void EnsureCapacity()
        {
            int newSize = Items.Length * 2;
            Array.Copy(Items, Items, newSize);
        }

        public void Add(T data)
        {
            if(Capacity == Items.Length)
            {
                EnsureCapacity();
            }
            Items[Capacity++] = data;
        }

        public T GetData(int idx)
        {
            if(idx >= Capacity || idx < 0)
            {
                throw new IndexOutOfRangeException("Index: " + idx + ", Capacity: " + Capacity);
            }
            return (T)Items[idx];
        }
    }

}
