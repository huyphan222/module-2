using System;

namespace BT2dAnd3d
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD();
            a.SetXYZ(4,5,1);
            Console.Write(a.ToString());
        }
    }
}
