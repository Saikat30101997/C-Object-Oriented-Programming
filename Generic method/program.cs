using System;
using System.Collections.Generic;

 

namespace visual_studio

{
   public class example
   {
      public void check<T>(T a,T b)
      {
          if(a.Equals(b))
          {
            Console.WriteLine("True");
          }
          else Console.WriteLine("False");
      }
   }

   
    class Program

    {
        static void Main(string[] args)
        {
         
           example e=new example();
           e.check(70,10);
          
        }

    }

}