using System;

namespace THHeCacDoiTuongHinhHoc
{
    public class Rectangle:Shape
    {
       private double _width = 1.0;
       public virtual double Width
       {
           get { return _width; }
           set { _width = value; }
       }

       private double _length = 1.0;
       public virtual double Length
       {
           get { return _length; }
           set { _length = value; }
       }

        public Rectangle()

        {

        }
        public Rectangle(double width, double length)

        {
            _width = width;

            _length = length;
        }
        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            _width = width;
            _length = length;
        }

        public double GetArea()
        {
            double S = 0;
            return  S = _width * _length;
        }

        public double GetPerimeter()
        {
            double P = 0;
            return  P = 2*(_width + _length); 
        }

        public override string ToString()
        {
            return  $"A Rectangle with width={_width} and length={_length}, , which is a subclass of {base.ToString()}";
        }

        
    }
}