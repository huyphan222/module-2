using System;

namespace THCaiDatSapXepChen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rdnumber = new Random();
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Rdnumber.Next(101);
            }
            Console.WriteLine("---------before InsertionSort---------");
            PrintArr(arr);
            Console.WriteLine();
            Console.WriteLine("----------After InsertionSort---------");
            InsertionSort(arr);
            PrintArr(arr);

        }

        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +" ");
            }
        }

        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key; 
            }
        }
    }
}
