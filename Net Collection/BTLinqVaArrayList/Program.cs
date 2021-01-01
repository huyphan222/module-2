using System;
using System.Collections;
using System.Collections.Generic;

namespace BTLinqVaArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<staff> Staff = new List<staff>();
            Staff.Add(new staff("Nam",22,1));
            Staff.Add(new staff("Kien",21,2));
            Staff.Add(new staff("Giang",22,3));
            Staff.Add(new staff("Trung",21,4));
            Staff.Add(new staff("Thi",27,5));

           foreach (var item in Staff)
           {
               Console.WriteLine(item.showInfo());
           }

           

             
           
                        

           
        }
    }
}
