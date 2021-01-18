using System;
using System.IO;


namespace THSuDungLop_FileNotFoundException
{
    class Program
    {
        static void Main(string[] args)
        {
              try
            {
                // Read in nonexistent file.
                using (StreamReader reader = new StreamReader("not-there.txt"))
                {
                    reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                // Write error.
                Console.WriteLine(ex);
            }
        }
    }
}
