using System;

namespace THHeCacDoiTuongHinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape vongtron = new Circle(5,"yellow", true);
            Shape chunhat = new Rectangle(4,5,"red",false);
            Rectangle square = new Square(4);
            Console.WriteLine(square.ToString());

            Console.Write(chunhat.ToString());

        }
    }
}
