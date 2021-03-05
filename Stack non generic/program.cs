using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Linqq
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mystc = new Stack();
            mystc.Push("Saikat");
            mystc.Push(11608020);
            mystc.Push("JSE");
            mystc.Push(25000.00);
           

            foreach (var item in mystc)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------");

            foreach (object item in mystc)
            {
                Console.WriteLine(item);   //object diye o declare kortee pari... var er bodoleee
            }

            string a = mystc.Peek().ToString(); // top item k string e convert kore print korse
            Console.WriteLine(a);
            Console.WriteLine("-------------");

            mystc.Pop();

              foreach (var item in mystc)
            {
               Console.WriteLine(item);
            }

            Console.WriteLine(mystc.Contains(11608020));
        }

  
      

	
    }
}
