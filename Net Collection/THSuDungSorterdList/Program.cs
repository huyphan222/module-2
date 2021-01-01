using System;
using System.Collections;

namespace THSuDungSorterdList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList mySL = new SortedList();
            mySL.Add(2,"two");
            mySL.Add(1,"one");
            mySL.Add(3,"three");

            int myKey = 4;
           Console.WriteLine("The key {0} is {1}",myKey,mySL.Contains(myKey)? "In the SortedList" : "Not in the SorterdList");
           myKey = 2;
           Console.WriteLine("The key {0} is {1}",myKey,mySL.Contains(myKey)? "In the SortedList" : "Not in the SorterdList");

           string one = "one";
           Console.WriteLine("The value \"{0}\" is {1}",one,mySL.ContainsValue(one)? "In the SortedList" : "Not in the SorterdList");

           
           
        }
    }
}
