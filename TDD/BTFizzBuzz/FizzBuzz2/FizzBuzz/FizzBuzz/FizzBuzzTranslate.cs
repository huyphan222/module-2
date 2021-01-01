using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzTranslate
    {

        public string Checkinput(int n)
        {
            string chuc = "";
            string donvi = "";
      
            if (n < 10)
            {
                switch (n)
                {
                    case 1: 
                        return "mot";                   
                     case 2:
                        return "hai";
                    case 3: 
                        return "Fizz";
                    case 4:
                        return "bon";
                    case 5:
                        return "Buzz";
                    case 6:
                        return "sau";
                    case 7:
                        return "bay";
                    case 8:
                        return "tam";
                    case 9:
                        return "chin";
                }
            }
            else if(n > 10 && n < 20)
            {
                switch (n % 10)
                {
                    case 1:
                        return "muoi mot";
                    case 2:
                        return "muoi hai";
                    case 3:
                        return "Fizz";
                    case 4:
                        return "muoi bon";
                    case 5:
                        return "Buzz";
                    case 6:
                        return "muoi sau";
                    case 7:
                        return "muoi bay";
                    case 8:
                        return "muoi tam";
                    case 9:
                        return "muoi chin";
                }
            }
            else if(n >= 30 && n < 40)
            {
                if (n == 35)
                {
                    return "FizzBuzz";
                }
                else
                {
                    return "Fizz";
                }
            }
            else if(n >= 50 && n < 60)
            {
                if (n == 53)
                {
                    return "BuzzFizz";
                }
                else
                {
                    return "Buzz";
                }
            }
            else
            { // hang chuc
                switch ((n / 10) % 10)
                {
                    case 2:
                        chuc = "hai";
                        break;
                    case 4:
                        chuc = "bon";
                        break;
                    case 6:
                        chuc = "sau";
                        break;
                    case 7:
                        chuc = "bay";
                        break;
                    case 8:
                        chuc = "tam";
                        break;
                    case 9:
                        chuc = "chin";
                        break;
                }
                //hang don vi
                switch (n % 10)
                {
                    case 0:
                        donvi = "muoi";
                        break;
                    case 1:
                        donvi = "mot";
                        break;
                    case 2:
                       donvi = " hai";
                        break;
                    case 3:
                        return "Fizz";
                    case 4:
                        donvi = "bon";
                        break;
                    case 5:
                        return "Buzz";
                    case 6:
                        donvi = "sau";
                        break;
                    case 7:
                        donvi = "bay";
                        break;
                    case 8:
                        donvi = "tam";
                        break;
                    case 9:
                        donvi = "chin";
                        break;
                }
                return $"{chuc} {donvi}";
            }

            return "khong co so";
            
        }
    }
}
