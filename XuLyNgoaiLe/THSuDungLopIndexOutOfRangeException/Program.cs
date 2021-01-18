using System;
using System.Collections.Generic;

namespace THSuDungLopIndexOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0,new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int index = characters[6];            
            }
            catch (Exception ex )
            {              
               Console.WriteLine(ex);
            }
        }
    }
}
