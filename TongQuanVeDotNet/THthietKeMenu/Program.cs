using System;

namespace THthietKeMenu
{
    class Program
    {
        static void Main(string[] args)
        {
           

             int choice = -1 ;
             
            while (choice != 0){             
            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice!!!!");
            




            switch (choice)
            {
                case 1:
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("**********");
                    Console.WriteLine("  ******* ");
                    Console.WriteLine("   *****");
                    Console.WriteLine("    ***");
                    Console.WriteLine("     *");
                    break;
                case 2:
                    Console.WriteLine("********");
                    Console.WriteLine("********");
                    Console.WriteLine("********");
                    Console.WriteLine("********");
                    break;

                case 3:
                    Console.WriteLine("******");
                    Console.WriteLine("*    *");
                    Console.WriteLine("*    *");
                    Console.WriteLine("*    *");
                    Console.WriteLine("*    *");
                    Console.WriteLine("******");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("enter again");
                    break;
                                
            }
            }
            




        }
    }
}
