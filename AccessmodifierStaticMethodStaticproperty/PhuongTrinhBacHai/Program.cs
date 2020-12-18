using System;

namespace PhuongTrinhBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            double SoA,SoB,SoC;
            bool checkinput = false;
            do{
                 Console.WriteLine("nhap so A");
                 checkinput = Double.TryParse(Console.ReadLine(),out SoA);
            }while(!checkinput);
           
             do{
                 Console.WriteLine("nhap so B");
                 checkinput = Double.TryParse(Console.ReadLine(),out SoB);
            }while(!checkinput);
            
            do{
                 Console.WriteLine("nhap so C");
                 checkinput = Double.TryParse(Console.ReadLine(),out SoC);
            }while(!checkinput);
           

            QuadraticEquation a = new QuadraticEquation(SoA,SoB,SoC);
         
         

            if(a.GetDiscriminant() > 0)
            {
                Console.WriteLine($"PT co 2 nghiem phan biet{ a.Root1()}\t {a.Root2()}");
            }
            else if(a.GetDiscriminant() == 0)
            {
                Console.WriteLine($"PT co nghiem kep: {a.DoubleRoot()}");
            }
            else
            {
                Console.Write("PT vo phuc");
            }
        }
    }
}
