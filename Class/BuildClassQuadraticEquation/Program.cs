using System;

namespace BuildClassQuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double delta = 0;
            QuaraticEquation Phuongtrinh = new QuaraticEquation(5,10,1);
            delta = Phuongtrinh.GetDiscriminant();
            Phuongtrinh.GetRoot1();
            if(delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if(delta > 0)
            {
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                Console.WriteLine(Phuongtrinh.GetRoot1());
                
            }

        }
    }
}
