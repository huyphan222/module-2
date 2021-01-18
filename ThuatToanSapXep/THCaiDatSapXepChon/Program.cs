using System;

namespace THCaiDatSapXepChon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Random RdNumber = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = RdNumber.Next(100);
            }
            PrintArr(arr);
            Console.WriteLine();
            Console.WriteLine("Sau khi Sap xep chen");
            SelectionSort(arr);
            PrintArr(arr);

        }

        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void SelectionSort(int[] arr) 
         { 
            int n = arr.Length; 
            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++) 
            { 
                // Find the minimum element in unsorted array 
                int min_idx = i; 
                for (int j = i + 1; j < n; j++) 
                    if (arr[j] < arr[min_idx]) 
                        min_idx = j; 
  
            // Swap the found minimum element with the first 
            // element 
            int temp = arr[min_idx]; 
            arr[min_idx] = arr[i]; 
            arr[i] = temp; 
            } 
        } 
    }
}
