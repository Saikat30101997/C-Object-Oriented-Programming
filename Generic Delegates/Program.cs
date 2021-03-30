using System;
using System.Collections.Generic;
 //Extensionmethod namespace pass korsi extention method gulur sate bind korar jonno

namespace Leetcode {


    public delegate T Calculator<T>(T a,T b);
    class Program { 
       
        static int sum (int a,int b)
        {
            return a + b;
        }
        static string add(string a,string b)
        {
            return a + " " + b;
        }
       
      
        public static void Main(string[] args)
        {
            Calculator<int> calculator = sum;
            int x= calculator(10, 16);
            Console.WriteLine(x);
            Calculator<string> calculator1 = add;
           string s=  calculator1("Saikat", "Tushar");
            Console.WriteLine(s);
     
          
        }
    }

}