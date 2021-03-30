using System;
using System.Collections.Generic;
using Extentionmethod; //Extensionmethod namespace pass korsi extention method gulur sate bind korar jonno

namespace Leetcode {

    public interface Multiplug
    {
       public void Show();
    }
    

    public  class MultiplugSystem1 : Multiplug
    {
       
       public void Show()
        {
            MultiplugSystem1 m = new MultiplugSystem1();
            m.equipment1();
            m.equipment2();
            Shape s=new Shape();
            
            s.rectangle();
        }
     
    }
    public class AnonymousSystem
    {
        public Multiplug ms;
        public AnonymousSystem(Multiplug multiplug)
        {
            ms = multiplug;
        }

        public void AllSystem()
        {
            ms = new MultiplugSystem1();
            ms.Show();
        }
    }

    public  class Shape
    {
        
    }
    public static class twoPin
    {
        
      public static void rectangle(this Shape s)
        {
            Console.WriteLine("This is Rectangle for two Pin");

        }
        public static void equipment1(this MultiplugSystem1 m)
        {
            Console.WriteLine("200-400w");
        }
    }

    public static class threepin
    {
        public static void equipment2(this MultiplugSystem1 m)
        {
            Console.WriteLine("400-2500w");
        }
    }
   
    public  class Program { 
       
       
      
        public static void Main(string[] args)
        {
            AnonymousSystem an = new AnonymousSystem(new MultiplugSystem1());
            an.AllSystem();
        }
    }

}