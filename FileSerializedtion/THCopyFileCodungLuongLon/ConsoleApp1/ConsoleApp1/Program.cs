using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter source file: ");
            string SourcePath= Console.ReadLine();
            Console.Write("Enter desFile: ");
            string destinationPath = Console.ReadLine();

            FileInfo SourceFile = new FileInfo(SourcePath);
            FileInfo DestinationFile = new FileInfo(destinationPath);

            try
            {
                CopyFileUsingFileInfo(SourceFile, DestinationFile);
                Console.Write("Copy Complete");
            }
            catch (IOException e)
            {
                Console.WriteLine("Copy Fail Babe");
                Console.Error.Write(e.Message);
                
            }
            
        }

        private static void CopyFileUsingFileInfo(FileInfo source, FileInfo des)
        {
            source.CopyTo(des.FullName, true);
        }

        private static void CopyFileUsingStream(FileInfo source , FileInfo des)
        {
            Console.WriteLine("Start Copy using stream");
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader(source.FullName);
                writer = new StreamWriter(des.FullName);
                char[] buffer = new char[1024];
                int length;
                while ((length = reader.Read(buffer)) > 0 )
                {
                    writer.Write(buffer, 0, length);
                }
            }
            finally
            {
                reader.Close();
                reader.Dispose();
                writer.Close();
                writer.Dispose();
            }
        }
        
    }
}
