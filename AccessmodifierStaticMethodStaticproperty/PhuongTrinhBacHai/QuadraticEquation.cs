using System;

namespace PhuongTrinhBacHai
{
    public class QuadraticEquation
    {
        private double _a;
        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        private double _b;
        public double B
        {
            get { return _b; }
            set { _b = value; }
        }
        private double _c;
        public double C
        {
            get { return _c; }
            set { _c = value; }
        }
        public QuadraticEquation(double a , double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        
        public double GetDiscriminant()
        {
            double delta;
            return delta = _b - 4 * _a * _c;
        }
        public double Root1()
        {
            return -_b-Math.Sqrt(GetDiscriminant()) / 2*_a;
        }   
        public double Root2()
        {
             return _b-Math.Sqrt(GetDiscriminant()) / 2*_a;
        }

        public double DoubleRoot()
        {
            return -_b/2*_a;
        }
        
        
    }
}