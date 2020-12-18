using System;

namespace SystemTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localTime = DateTime.Now;
            System.Console.WriteLine("local time right now is: " + localTime);
        }
    }
}
