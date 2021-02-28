using System;

namespace visual_studio
{
    
   public class Vehicle
   {
      public string color;
      public double weight;
      public Vehicle (string c,double w)
      {
         color=c;
         weight=w;
      } 
      public virtual void attribute()
      {
         Console.WriteLine("Color: "+color);
         Console.WriteLine("Weight: "+weight);
      }
     
   }

}

