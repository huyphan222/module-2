namespace BT2dAnd3d
{
    public class TwoD
    {

            private double _x;
            public double X
            {
                get { return _x; }
                set { _x = value; }
            }

            private double _y;
            public double Y
            {
                get { return _y; }
                set { _y = value; }
            }  
   

            public TwoD()
            {
                
            }
            public TwoD(double x, double y)
            {
                _x = x;
                _y = y;
            }

            public void SetXY(double x , double y)
            {
                _x = x;
                _y = y;
            }

            public double[] GetXY()
            {
                double[] returnArray = {X,Y};
                return returnArray;
            }

        public override string ToString()
        {
            return $"{_x},{_y}";
        }



    }
}