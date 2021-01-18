using System;

namespace BTKhoiTaoHamSuDungGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<int> test = new MyGeneric<int>();
            int so1 = 5;
            int so2 = 4;
            Console.WriteLine(test.CompareGeneric(ref so1,ref so2));
            MyGeneric<string> test2 = new MyGeneric<string>();
            string strA = "Phuc";
            string strB = "Phuc";
            Console.WriteLine(test2.CompareGeneric(ref strA, ref strB));


        }
    }
}
