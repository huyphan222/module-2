using System;

namespace THHeCacDoiTuongHinhHoc
{
    public class Shape
    {
        private string _color = "green";
        private bool _filled = false;
        public bool Filled
        {
            get { return _filled; }
            set { _filled = value; }
        }
        

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public  Shape()
        {
        
        }
        public Shape(string color , bool fill)
        {
            _color = color;
            _filled = fill;
        }

       public override string ToString()
       {
           return $"A Shape with color of{_color} and {_filled}";

       }
        

    }
}