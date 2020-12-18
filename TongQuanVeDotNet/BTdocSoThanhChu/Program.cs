using System;

namespace BTdocSoThanhChu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double input;
            bool checkinput = false;
            
            do{
                checkinput = double.TryParse(Console.ReadLine(),out input);
            }while(input < 0 || !checkinput);

            if (input < 10)
            {
                switch(input)
                {
                    case 0:
                    Console.Write("zero");
                    break;
                    case 1:
                    Console.Write("one");
                    break;
                     case 2:
                    Console.Write("two");
                    break;
                     case 3:
                    Console.Write("three");
                    break;
                     case 4:
                    Console.Write("pho");
                    break;
                     case 5:
                    Console.Write("five");
                    break;
                     case 6:
                    Console.Write("shit");
                    break;
                     case 7:
                    Console.Write("seven");
                    break;
                     case 8:
                    Console.Write("eight");
                    break;
                     case 9:
                    Console.Write("nice");
                    break;         
                }              
            }
            else if (input < 20)
            {
                switch(input)
                {
                      case 10:
                    Console.Write("ten");
                    break;
                    case 11:
                    Console.Write("eleven");
                    break;
                     case 12:
                    Console.Write("twelve");
                    break;
                     case 13:
                    Console.Write("thirteen");
                    break;
                     case 14:
                    Console.Write("fourteen");
                    break;
                     case 15:
                    Console.Write("fifteen");
                    break;
                     case 16:
                    Console.Write("sixteen");
                    break;
                     case 17:
                    Console.Write("seventeen");
                    break;
                     case 18:
                    Console.Write("eighteen");
                    break;
                     case 19:
                    Console.Write("nineteen");
                    break;         
                }
            }

            else if(input < 100)
            {
                switch(Math.Floor((double)input / 10))
                {
                    
                    case 2: 
                    Console.Write("twenty ");
                    break;
                    case 3: 
                    Console.Write("thirty ");
                    break;
                    case 4: 
                    Console.Write("pho ");
                    break;
                    case 5: 
                    Console.Write("fifty ");
                    break;
                    case 6: 
                    Console.Write("sixty ");
                    break;
                    case 7: 
                    Console.Write("seventy ");
                    break;
                    case 8: 
                    Console.Write("eighty ");
                    break;
                    case 9: 
                    Console.Write("ninety ");
                    break;
                    
                }
                switch(input % 10)
                {
                    case 0 :
                        Console.Write("");
                        break;
                     case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3 :
                        Console.Write("three");
                        break;
                    case 4 :
                        Console.Write("four");
                        break;
                    case 5 :
                        Console.Write("five");
                        break;
                    case 6 :
                        Console.Write("six");
                        break;
                     case 7 :
                        Console.Write("seven");
                        break;
                    case 8 :
                        Console.Write("eight");
                        break;
                    case 9 :
                        Console.Write("nice");
                        break;
                }
            }

            else if(input < 1000)
            {
              switch(Math.Floor(input/100))
                {
                    case 1: Console.Write("one hundred ");
                    break;
                    case 2: Console.Write("two hundred ");
                    break;
                    case 3: Console.Write("three hundred ");
                    break;
                    case 4: Console.Write("four hundred ");
                    break;
                    case 5: Console.Write("five hundred ");
                    break;
                    case 6: Console.Write("six hundred ");
                    break;
                    case 7: Console.Write("seven hundred ");
                    break;
                    case 8: Console.Write("eight hundred ");
                    break;
                    case 9: Console.Write("nine hundred ");
                    break;
                }
                if(Math.Floor(input/10)%10 == 1)
                {
                    switch(input%10)
                    {
                        case 0: Console.Write("ten");
                        break;
                        case 1: Console.Write("eleven");
                        break;
                        case 2: Console.Write("twelve");
                        break;
                        case 3: Console.Write("thirteen");
                        break;
                        case 4: Console.Write("fourteen");
                        break;
                        case 5: Console.Write("fifteen");
                        break;
                        case 6: Console.Write("sixteen");
                        break;
                        case 7: Console.Write("seventeen");
                        break;
                        case 8: Console.Write("eighteen");
                        break;
                        case 9: Console.Write("nineteen");
                        break;
                    }
                }
                else
                {
                    switch(Math.Floor(input/10)%10)
                    {
                        case 0: Console.Write("");
                        break;
                        case 2: Console.Write("and twenty");
                        break;
                        case 3: Console.Write("and thirty");
                        break;
                        case 4: Console.Write("and fourty");
                        break;
                        case 5: Console.Write("and fifty");
                        break;
                        case 6: Console.Write("and sixty");
                        break;
                        case 7: Console.Write("and seventy");
                        break;
                        case 8: Console.Write("and eighty");
                        break;
                        case 9: Console.Write("and ninety");
                        break;
                    }
                    switch(input % 10)
                    {
                        case 0: Console.Write("");
                        break;
                        case 1: Console.Write(" one");
                        break;
                        case 2: Console.Write(" two");
                        break;
                        case 3: Console.Write(" three");
                        break;
                        case 4: Console.Write(" four");
                        break;
                        case 5: Console.Write(" five");
                        break;
                        case 6: Console.Write(" six");
                        break;
                        case 7: Console.Write(" seven");
                        break;
                        case 8: Console.Write(" eight");
                        break;
                        case 9: Console.Write(" nine");
                        break;
                    } 
                }  
              
        }
    }
    }
    
}
