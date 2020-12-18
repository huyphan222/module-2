using System;

namespace BuildClassOfFan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            Fan fan2 = new Fan();
            fan1.on = true;
            fan1.speed = 3;
            fan1.radius = 10;
            fan1.color = "yellow";
            fan2.speed = 2;
            fan2.radius = 5;

            Console.Write(fan1.toString());
            Console.WriteLine();
               Console.Write(fan2.toString());
            
            
        }
    }
}
