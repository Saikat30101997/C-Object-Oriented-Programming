using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

 

namespace visual_studio

{
    public delegate void calculation(int a,int b); // addition nwr jonno ami delegate create korlm jar return type + parameter shb additon er moto
    
    class Program

    {
        public static void addition(int a,int b)
        {
            int sum=a+b;
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            
           
           calculation obj= new calculation(Program.addition); // static use korar karon  amr program diye addition method k call korte parsi
           obj.Invoke(10,20); // invoke diye ami parameter gula nilam

        
        }

    }

}
