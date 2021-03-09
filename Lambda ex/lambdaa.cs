using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;



namespace lambda

{
    public delegate void  Mydelegate(int num);
    public delegate int m1(int num);
    public delegate int cal(int num1, int num2);
    class Program

    {


        static void Main(string[] args)
        {
            Mydelegate obj = (a) =>      //statement lambda
            {
                a += 5;
                Console.WriteLine(a);
            };

            obj(10);

            m1 o = (a) => a+=5;   //expression lambda
            Console.WriteLine(o.Invoke(10));

            cal c = (a, b) => a + b;
            Console.WriteLine(c(10, 17));




        }

    }

}