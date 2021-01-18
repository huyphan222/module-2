using System;
using System.IO;

namespace THTinhTongCacSoTrongFile
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"D:\module-2\FileSerializedtion\THTinhTongCacSoTrongFile\FileDem.txt";
            Console.WriteLine("File path: " + path);
            Program example = new Program();
            example.ReadTextFile(path);

          
        }

        void ReadTextFile(string filePath)
        {
            try
            {
                FileInfo file = new FileInfo(filePath);
                if(!file.Exists)
                {
                    throw new FileNotFoundException();
                }
                StreamReader reader = new StreamReader(filePath);
                string line = "";
                int sum = 0;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    sum += Int32.Parse(line);
                }
                reader.Close();
                Console.WriteLine("Total: " + sum);
                
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("File not found or invalid content");
            }          
        }
    }   
}
