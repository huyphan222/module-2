using System;

namespace ThietKeMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu ");
            Console.WriteLine("1. the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            int input;
            bool checkinput = false;

            do{
                checkinput = Int32.TryParse(Console.ReadLine(), out input);
            }while (input < 0 || !checkinput);

            switch (input)
            {
                case 1:
                    Console.WriteLine("********* ");
                    Console.WriteLine(" ******* ");
                    Console.WriteLine("   *** ");
                    Console.WriteLine("    *");
                break;

                case 2:
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                    break;
                case 3:
                    for(int i=0; i < 7; i++)
                    {
                        for(int j=0; j<5; j ++)
                        {
                            
                            if (i >= 1 && i <= 6)
                            {
                                if(j >=1 && j <= 3)
                                {
                                    Console.Write(" ");
                                }
                                else
                                {
                                    Console.Write("*");
                                }
                            }
                        }

                                                    
                        Console.WriteLine(" ");
                    }
                    break;
                  case 0:
                     Environment.Exit(0);
                     break;
                  default:
                    Console.WriteLine("No choice!");
                    break;

            }
        }
    }
}
