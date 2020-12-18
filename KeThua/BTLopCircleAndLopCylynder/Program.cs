using System;

namespace BTLopCircleAndLopCylynder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle a = new Circle();
            Cylinder b = new Cylinder();
            b.Radius = 20;
            b.Height= 10;
            // Console.Write(a.ToString());
            Console.Write(b.GetArea());
            Console.Write(b.ToString());
        }
    }
}
