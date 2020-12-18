using System;

namespace THgiaiPTbacNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a ,b;
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
            bool checkinput = false;

            do
            {
                Console.Write("moi nhap a = " );
                checkinput = int.TryParse(Console.ReadLine(), out a);
            } while (a < 0 || !checkinput);
            
            do
            {
                Console.Write("moi nhap b = ");
                checkinput = int.TryParse(Console.ReadLine(), out b);
            } while (b < 0 || !checkinput);

            if (a == 0)
            {
                if(b == 0)
                {
                    Console.Write("Phuong trinh co vo so nghiem ");
                }
                else
                {
                    Console.Write("phuong trinh zo nghiem");
                }
            }
            else
            {
                Console.Write("phuong trinh co 1 nghiem duy nhat la  -{0}/{1} = {2} ",b,a,(double)-b/a);
            }


        }
    }
}
