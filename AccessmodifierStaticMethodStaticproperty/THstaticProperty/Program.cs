using System;

namespace THstaticProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car("Mazda 3", "Skyactiv 3");
          Console.WriteLine(car.numberOfCars);
          car car2 = new car("Mazda 6", "Skyactiv 6");
          Console.WriteLine(car.numberOfCars);
          Console.ReadLine();
           
        }
    }
}
