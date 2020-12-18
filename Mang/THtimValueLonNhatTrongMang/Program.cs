using System;

namespace THtimValueLonNhatTrongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            bool checksize = false;

            do{
                Console.WriteLine("nhap do dai cua size toi da 20");
                checksize = Int32.TryParse(Console.ReadLine(),out size);
            }while(size > 20 || !checksize);

            int[] array = new int[size];
            for (byte i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter element : {0}",i+1);
                array[i] = Int32.Parse(Console.ReadLine());
            }

             Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++) 
            {
                 Console.WriteLine("player{0} has {1} points ",j+1,array[j]);
            }



            int max = array[0];
            int index = 0;
            for (byte j = 1 ;j < array.Length; j++)
            {
                if(array[j] > max)
                {
                    max = array[j];
                    index = j;
                }                 
            }
            Console.WriteLine(max +" "+ (index+1));


           

           


        }
    }
}
