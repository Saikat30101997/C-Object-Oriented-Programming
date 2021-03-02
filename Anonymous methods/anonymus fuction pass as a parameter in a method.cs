using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

 

namespace visual_studio

{
   public delegate void Mydelegate(int num);
    class Program

    {
        public static void mymethod(Mydelegate b,int a)
        {
              a+=10;
              b(a);
        }

        static void Main(string[] args)
        {
           Program.mymethod(delegate(int a){a*=10;Console.WriteLine(a);},15);
        
        }

    }

}