using System;

namespace THtimValueTrongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[]{"simple","divice","stewie2k","autimatic","shroud","kennys","happy"};
            Console.Write("Enter a name of students: ");
            string input_name = Console.ReadLine();
            bool isExist = false;

            for (byte i = 0; i < students.Length; i++)
            {
                if(students[i].Equals(input_name))
                {
                    Console.Write("the position of the students in the list {0} is {1}",input_name,i+1);
                    isExist = true;
                    break;
                }
                if(!isExist)
                {
                    Console.WriteLine("not found {0} in the list",input_name);
                }
            }
        }
    }
}
