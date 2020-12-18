namespace BuildClassOfFan
{
    public class Fan
    {
        public const int _SLOW = 1;
        public const int _MEDIUM = 2;

        public const int _FAST = 3;

        private int _speed;
        public int speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        private bool _on = false;
        public bool on
        {
            get { return _on; }
            set { _on = value; }
        }

        private double _radius = 5;
        public double radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        
        private string _color = "blue";
        public string color
        {
            get { return _color ; }
            set { _color = value; }
        }

        public Fan(){
            
        }

        public string toString(){
            if(_on)
            {
                return $"speed is {_speed}\n color is: {_color}\n'radius is {_radius}\n fan is on";
            }
            else
            {
                return $"speed is {_speed}\n color is: {_color}\nradius is {_radius}\n fan is off";
            }
        }
        
        
        



    }
       
        

        

         
     
}   