using System;

namespace StopWatch
{
    class Program
    {

        static void Main(string[] args)
        {
           
            Random r = new Random();
            StopWatch a = new StopWatch();


            int[] array = new int[1000000]; 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1,1001);
            }
            a.startTime = DateTime.Now;
            Sort(ref array);
            a.endTime = DateTime.Now;
            Console.Write(a.GetElapsedTime());


           
          

         
        }


        static void Sort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = array[i];
                int indexMin = i;
                for (int j = i; j < array.Length; j++ )
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        indexMin = j;
                    }
                }
                int temp = array[i];
                array[i] = array[indexMin];
                array[indexMin] = temp;
            }
        }

    }



}
