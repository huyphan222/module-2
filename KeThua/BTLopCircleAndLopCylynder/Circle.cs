using System;

namespace BTLopCircleAndLopCylynder
{
    public class Circle
    {
        private double _radius = 1;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value;}
        }

        private string _color = "red";
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public double GetArea()
        {
            double S;
           return S = _radius *_radius * Math.PI;

        }
        
        public override string ToString()
        {
            return  $"Radius = {_radius}\t Color :{_color}";
        }
        
    }
}