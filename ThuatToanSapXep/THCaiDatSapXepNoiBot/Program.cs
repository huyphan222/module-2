using System;

namespace THCaiDatSapXepNoiBot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {14,2,5,77,55,45,8};  
            PrintArray(arr);
            Console.WriteLine("---------- Sau khi BubbleSort-------");  
            BubbleSort(arr);
            PrintArray(arr);     
        }

        static void BubbleSort(int[] arr)
        {
            int temp;
            int n = arr.Length;
           bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }      
                 if (swapped == false)
            {
                break;
            }         
            }
           
        }

        static void PrintArray(int []arr) 
        { 
        int i; 
        for (i = 0; i < arr.Length; i++) 
            Console.Write(arr[i] + " "); 
        Console.WriteLine(); 
        } 
    }
}
