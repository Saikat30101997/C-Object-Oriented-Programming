using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

 

namespace visual_studio

{
    public delegate void calculation(int a,int b); // addition nwr jonno ami delegate create korlm jar return type + parameter shb additon er moto
    public delegate void cal(int a);
    class Program

    {
        public static void addition(int a,int b)
        {
            int sum=a+b;
            Console.WriteLine(sum);
        }
        public static void substraction(int a,int b)
        {
            int sub=a-b;
            Console.WriteLine(sub);
        }
        public static void square(int num)
        {
            Console.WriteLine(num*num);
        }

        public static void cube(int num)
        {
            Console.WriteLine(num*num*num);
        }
        static void Main(string[] args)
        {
            
           
           calculation obj= new calculation(Program.addition); // static use korar karon  amr program diye addition method k call korte parsi
           obj.Invoke(10,20); // invoke diye ami parameter gula nilam
           obj=substraction; // amra evabe o method k call dite pari
           obj(10,20); // parameter gula k evabe o pass korte parii

           cal ob = new cal(Program.square);
           ob.Invoke(6);
           


        
        }

    }

}