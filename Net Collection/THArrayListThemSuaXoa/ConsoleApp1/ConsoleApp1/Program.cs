using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            ArrayList arrStudent = new ArrayList();
            arrStudent.Add(new Student("phuc", 23));
            arrStudent.Add(new Student("ronaldo", 35));
            arrStudent.Add(new Student("messi", 33));

            
            arrStudent[0] = new Student("terry", 40);

            foreach (Student student in arrStudent)
                Console.WriteLine(student.Name + " " + student.Age);
            Console.WriteLine();
            arrStudent.RemoveAt(2);

            foreach (Student student in arrStudent)
                Console.WriteLine(student.Name + " " + student.Age);


            Console.ReadKey();

        }
    }
}
