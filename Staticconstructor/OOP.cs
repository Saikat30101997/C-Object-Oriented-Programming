using System;

namespace visual_studio
{
    
     public class StopWatch
{
    // static constructor
    static StopWatch()
    {
        Console.WriteLine("Static constructor called");
    }

    // instance constructor
    public StopWatch()
    {
        Console.WriteLine("Instance constructor called");
    }

    // static method
    public static void DisplayInfo()
    {
        Console.WriteLine("DisplayInfo called");
    }

    
}

}

