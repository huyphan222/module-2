using System;

namespace CheckNamNhuan
{
    class Program
    {
        static void Main(string[] args)
        {    
            int year; 
            bool isLeapYear = false;                
            Console.Write("moi nhap so nam de check: ");            
             year = Convert.ToInt32(Console.ReadLine()); 

            while (year < 0)
            {
                 Console.WriteLine("so nam ban nhap vao khong hop le vui long nhap lai");
                 year = Convert.ToInt32(Console.ReadLine());  
            }
            
            bool isDivisible4 = year % 4 == 0;
            if(isDivisible4)
            {
                bool isDivisible100 = year % 100 == 0;
                if(isDivisible100)
                {
                    bool isDivisible400 = year % 400 == 0;
                    if (isDivisible400)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }

            if (isLeapYear)
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
          
     }        
    }        
}



