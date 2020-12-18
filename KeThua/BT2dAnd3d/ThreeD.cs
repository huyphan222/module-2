namespace BT2dAnd3d
{
    public class ThreeD:TwoD
    {
        private double _z;
        public double Z 
        {
            get { return _z; }
            set { _z = value; }
        }

        public ThreeD()
        {
            
        }
        public ThreeD(double x , double y) : base (x,y)
        {
            
        }

        public void SetXYZ(double x , double y , double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double[] GetXYZ()
        {
             double[] returnArray = {X,Y,Z};
                return returnArray;
        }

        public override string ToString()
        {
            return $"{X},{Y},{Z}";
        }



        
    }
}