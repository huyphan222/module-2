namespace THlopChuNhat
{
    public class Rectangle
    {
       public int _width;
       public int _heigh;

        public Rectangle(){

    }
        public Rectangle(int width ,int height)
        {
            _width = width;
            _heigh = height;
        }
        
        public int GetArea()
        {
            return _width * _heigh; 
        }

        public int Getpremier()
        {
            return (_width + _heigh) * 2;
        }

       

    

    }
       


       
}