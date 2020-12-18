namespace THHeCacDoiTuongHinhHoc
{
    public class Square:Rectangle
    {
        private double _side;
        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }
         public Square()
        {

        }

        public Square(double side) : base(side, side)
        {
            _side = side;
        }
        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
            _side = side;
        }

        public override double Length { get => base.Length; set => base.Length = _side; }

        public override double Width { get => base.Width; set => base.Width = _side; }

        public override string ToString()
        {
            return $" A Square with side={_side} , which is a subclass {base.ToString()}";
        }







        
    }
}