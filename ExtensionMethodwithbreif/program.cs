using System;
using System.Collections.Generic;
using Extentionmethod; //Extensionmethod namespace pass korsi extention method gulur sate bind korar jonno

namespace Leetcode {
   
    public class Program { 
       
      
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Fun1();
            p.Fun2(10);
            int y = 10;
            var text = 1;
            var ans = text.ToEnglish();

          

            Console.WriteLine(ans);
        }
    }

}