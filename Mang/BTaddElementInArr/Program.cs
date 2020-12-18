using System;

namespace BTaddElementInArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6};
                   
            Console.Write("nhap so can chen: ");
            int value = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap vi tri index can chen: ");
            int index = Int32.Parse(Console.ReadLine());


            Array.Resize(ref array,array.Length+1);
            for (int i = array.Length-1; i > index ; i--)
            {
                array[i] = array[i-1];
            }
            array[index] = value;

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }






            
            

            
          
        }
    }
}
