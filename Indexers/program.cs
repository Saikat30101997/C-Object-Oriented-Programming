using System;
using System.Collections.Generic;

namespace lambda
{
    public class Ind
    {
        public static int  n=10;
        private int[] age = new int[n];

       
       
        public int this[int index]
        {
            get {
               
                    return age[index];
             
            }
            set {

              
                    if (value >= 0)
                    {
                        age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("not a valid value");
                    }
               

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
       
            Ind i = new Ind();
            i[0] = 5;
            Console.WriteLine(i[0]);
            i[11]= 7;
           
            

        }
    }

}

