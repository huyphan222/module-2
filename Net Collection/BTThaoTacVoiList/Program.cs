using System;
using System.Collections.Generic;

namespace BTThaoTacVoiList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animal = new List<string>();
            animal.Add("lion");
            animal.Add("cat");
            animal.Add("dog");

            foreach (var item in animal)
            {
                Console.WriteLine(item);
            } 
            animal.Remove("dog");
            Console.WriteLine();
              foreach (var item in animal)
            {
                Console.WriteLine(item);
            } 
            Console.WriteLine();


            animal.Sort();
             foreach (var item in animal)
            {
                Console.WriteLine(item);
            } 


        }
    }
}
