using System;
using System.Collections.Generic;

 

namespace visual_studio

{
   public class example<T>
   {
     T box;
     public T Box { 

         set
         {
             this.box=value;
         } 
         get 
         {
             return box;

         }     
     }
     
     
   }

   
    class Program

    {
        static void Main(string[] args)
        {
         example<int>e=new example<int>();
         
         e.Box=20;
         Console.WriteLine(e.Box);
         
        }

    }

}