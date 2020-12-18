using System;

namespace StopWatch

{
    public class StopWatch
    {
     private DateTime _startTime;
     public DateTime startTime
     {
         get { return _startTime; }
         set { _startTime = value; }
     }

     private DateTime _endTime;
     public DateTime endTime
     {
         get { return _endTime; }
         set { _endTime = value; }
     }

     public void setTime()
     {
        _startTime = DateTime.Now;
     }

     public DateTime start()
     {
         return _startTime = DateTime.Now;
     }

     public DateTime stop()
     {
        return  _endTime = DateTime.Now;
     }
     

      public double GetElapsedTime()
    {
        return (_endTime - _startTime).TotalMilliseconds;   
    }
 }
}