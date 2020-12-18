namespace BTLopCircleAndLopCylynder
{
    public class Cylinder:Circle
    {
        private int _height;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }



        public override string ToString()
        {
            return   $" height= {_height},{base.ToString()}";
        }



        
    }
}