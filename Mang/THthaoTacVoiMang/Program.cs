using System;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (byte i = 0;i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = 0;

            for (byte i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            Console.Write("the total is {0}",total);

        }
    }
}
