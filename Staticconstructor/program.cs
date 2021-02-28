using System;

namespace visual_studio
{
       class Program
    {
        static void Main(string[] args)
        {
          StopWatch.DisplayInfo();
          StopWatch.DisplayInfo(); 

          StopWatch sw1 = new StopWatch(); // First static constructor and then instance constructor called 
          StopWatch sw2 = new StopWatch();// only instance constructor called 
          StopWatch.DisplayInfo();
        }
    }
}
