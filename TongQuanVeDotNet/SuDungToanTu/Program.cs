using System;

namespace SuDungToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.Write("enter width: ");
            width = Convert.ToSingle(Console.ReadLine());
            Console.Write("enter height: ");
            height = Convert.ToSingle(Console.ReadLine());

            float area = width * height;
            Console.Write("area is: " + area);

            
        }
    }
}
