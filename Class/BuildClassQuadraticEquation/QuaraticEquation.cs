using System;

namespace BuildClassQuadraticEquation
{
    public class QuaraticEquation
    {
        private double _a;
        public double a
        {
            get { return _a; }
            set { _a = value; }
        }
        private double _b;
        public double b
        {
            get { return _b; }
            set { _b = value; }
        }
        
        
        private double _c;
        public double c
        {
            get { return _c; }
            set { _c = value; }
        }

        public QuaraticEquation(double A , double B , double C)
        {
            _a = A;
            _b = B;
            _c = C;
        }

        public double GetDiscriminant()
        {
            double delta = 0;
            return  delta = _b*_b - 4*_a*_c;
        }

        public double GetRoot1()
        {
            double r1 = 0;
            return  r1 = (-_b + Math.Sqrt(GetDiscriminant()) / 2*_a);
        }

         public double GetRoot2()
        {
            double r2 = 0;
            return  r2 = (_b + Math.Sqrt(GetDiscriminant()) / 2*_a);
        }


        
    }
}