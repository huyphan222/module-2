using System;
using System.Collections.Generic;

namespace BTKhoiTaoHamSuDungGeneric
{
    public class MyGeneric<T>
    {
        public bool CompareGeneric( ref T a , ref T b)
        {
            if(a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}