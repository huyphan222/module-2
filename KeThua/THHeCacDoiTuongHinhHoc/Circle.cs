using System;

namespace THHeCacDoiTuongHinhHoc
{
    public class Circle:Shape
    {
        private double _radius = 1;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public Circle()
        {
            
        }
        public Circle(double radius)
        {
            radius = _radius;
        }

        public Circle(double radius , string color , bool check): base (color , check)
        {
            _radius = radius;  
        }

        public double GetArea()
        {
            double S = 0;
            return S = Math.PI * _radius * _radius;

        }   

        public double GetPerimeter()
        {
            double S = 0;
            return S = Math.PI * _radius * 2;
        }  

        public override string ToString()
        {
            return $"A circle with radius = {_radius} , which is a subclass of  {base.ToString()}";
        }


    }
}