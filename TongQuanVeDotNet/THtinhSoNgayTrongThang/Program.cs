using System;

namespace THtinhSoNgayTrongThang
{
    class Program
    {
        static void Main(string[] args)           
        {
            bool check = false;
            int month , year; 
            bool isLeapyear = false;

            do
            {
                Console.Write("enter month: ");
                check = int.TryParse(Console.ReadLine(), out month);
            } while (month <= 0 || !check || month > 12);     

            do
            {
                Console.Write("enter year: ");
                check = int.TryParse(Console.ReadLine(), out year);
            } while (!check || year < 0);   

           
            bool isDivisible4 = year % 4 == 0;
            if (isDivisible4){
                bool isDivisible100 = year % 100 == 0;
                if (isDivisible100)
                {
                    bool isDivisible400 = year % 400 == 0;
                    if(isDivisible400)
                    {
                        isLeapyear = true;
                    }
                }
                else
                {
                    isLeapyear = true;
                }
            } 

            
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                Console.WriteLine("thang {0} co 31 ngay" , month);
                break;
                case 2:
                    if(isLeapyear)
                    {
                        Console.WriteLine("Thang {0} co 29 ngay vi la nam nhuan {1}", month , year);
                    }
                    else
                    {
                        Console.WriteLine("thang {0} co 28 ngay" , month);
                    }
                break;

                case 4:
                case 6:
                case 9:
                case 11:
                Console.WriteLine("thang {0} co 31 ngay" , month);
                break;    
                default:
                Console.WriteLine("loi~");
                break;  

            }

            



        }
    }
}
