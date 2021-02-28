using System;
using System.Collections.Generic;

 

namespace visual_studio

{
   public class example<T>
   {
     T box;
     public example(T b)
     {
         this.box=b;
     }

     public void print()
     {
         Console.WriteLine(box);
     }
   }

   
    class Program

    {
        static void Main(string[] args)
        {
         example<int>e=new example<int>(60);
         e.print();
        }

    }

}