using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    public class TriangleClassifier
    {
        public string Check(int a, int b , int c)
        {
            if (a + b > c && b + c > a && a + c > b)
            {
                if (a == b && b == c)
                {
                    return "Tam giac deu";
                }
                else if (a == b || b == c || c == a)
                {
                    return "Tam giac can";
                }
                else
                {
                    return "Tam giac";
                }

            }
            else
            {
                return "Khong phai tam giac";
            }

           

            
        }
    }
}
