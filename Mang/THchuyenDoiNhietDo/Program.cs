using System;

namespace THchuyenDoiNhietDo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU!!");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit ");
            bool checkinput = false;
            int input;
            do{
                checkinput = Int32.TryParse(Console.ReadLine(),out input);
            }while (input > 2 || !checkinput);

            switch (input)
            {
                case 1:
                    Console.WriteLine("moi nhap do F");
                    int doF;
                      do{
                         checkinput = Int32.TryParse(Console.ReadLine(),out doF);
                        }while (!checkinput);
                        double doC = fahrenheitToCelsius(doF);

                
                    Console.WriteLine("{0} do F chuyen sang do C = {1}",doF,doC);
                    break;

                 case 2:
                    Console.WriteLine("moi nhap do C");
                    int celsius;
                      do{
                         checkinput = Int32.TryParse(Console.ReadLine(),out celsius);
                        }while (!checkinput);
                        double do_F = celsiusToFahrenheit(celsius);

                
                    Console.WriteLine("{0} do C chuyen sang do F = {1}",celsius,do_F);
                    break;   

                case 0:
                Environment.Exit(0);
                break;
            }   


            
        }

        public static double celsiusToFahrenheit(double celsius)
        {
            double Fahrehenit;
            return  Fahrehenit = 9/5 * celsius + 32;  
        }

        public static double fahrenheitToCelsius(double fahrenheit)
        {
            double Celsius;
            return Celsius = (fahrenheit - 32) / 1.8;
        }

    }
}
