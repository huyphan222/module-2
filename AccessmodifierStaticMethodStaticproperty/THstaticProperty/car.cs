namespace THstaticProperty
{
    public class car
    {
        private string _name;
        public string engine;
        public static int numberOfCars = 0;

      
        public car(string name, string engine) {
        _name = name;
        this.engine = engine;
        numberOfCars++;
        }

        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
    }
}