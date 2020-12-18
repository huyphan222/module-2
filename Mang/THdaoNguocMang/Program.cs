using System;

namespace THdaoNguocMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            
            bool check = false;
            // int[] array;
            do{
                Console.Write("nhap size: ");
                check = Int32.TryParse(Console.ReadLine(),out size);
                if (size > 20)
                {
                    Console.WriteLine("ko dc nhap qua so 20");
                }

            }while(size > 20 || !check);

            int[] array = new int[size];
            byte i = 0;
            while(i < array.Length)
            {
                Console.Write("Enter element {0} : ",i+1);
                array[i] = Int32.Parse(Console.ReadLine()); 
                i++;
            }

            Console.WriteLine("Elements in array: ", "");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }

            for (int j = 0; j < array.Length / 2; j++) 
            {
                int temp = array[j];
                array[j] = array[size - 1 - j];
                array[size - 1 - j] = temp;
            }

            Console.WriteLine("Reverse array: ", "");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }


        }
    }
}
