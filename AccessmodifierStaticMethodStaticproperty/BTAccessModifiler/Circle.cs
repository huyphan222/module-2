namespace BTAccessModifiler
{
    public class Circle
    {
        private double _radius = 1;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        private string _color = "red";
        public string Color
        {
            get { return _color; }
            set { _color = value; }        
        }
        public Circle()
        {
            
        }
        public Circle(double radius)
        {
            _radius = radius;
        }
        
        public void GetRadius()
        {
            
        }

        public void GetArea()
        {
            
        }

        
    }
}