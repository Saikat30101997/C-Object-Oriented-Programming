using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

 

namespace visual_studio

{
   public delegate void Mydelegate(int num);
    class Program

    {
        public static void mymethod(int a)
        {
              a+=10;
              Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            
           Mydelegate m= delegate(int a) // anonymus fun or method
           {
               a+=10;
               Console.WriteLine(a);
           };
           m(10);
      


        
        }

    }

}
