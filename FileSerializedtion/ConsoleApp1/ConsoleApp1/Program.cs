using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $@"D:\module-2\FileSerializedtion\BTCopyFile";
            string source = "source.txt";
            string targetFile = "target.txt";
            string data = string.Empty;

            using (StreamReader sr = new StreamReader($@"{path}\{source}"))
            {
                data = sr.ReadToEnd();
            }

            using (StreamWriter sw = new StreamWriter($@"{path}\{targetFile}"))
            {
                sw.WriteLine(data);
            }
             

        }
    }
}
