using System;

namespace visual_studio
{

    public class Student
    {
     public static int count=0;
    public Student()
     {
         count++;
     }
     public void printfn()
     {
         Console.WriteLine("Students no: "+count);
     }
    }
}

