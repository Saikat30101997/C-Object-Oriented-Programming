using System;
using System.Collections.Generic;

namespace Delegates
{
    public class oldclass
    {
        public void method1()
        {
            Console.WriteLine("Hello");

        }
    }

    public static class newclass
    {
        public static void method2(this oldclass o)
        {
            Console.WriteLine("Hello2");
        }

        public static void method3(this oldclass o)
        {
            Console.WriteLine("hello3");
        }
    }
   
   class Program {
        static void Main(string[] args)
        {
            oldclass o = new oldclass();
            o.method1();
            o.method2();
            o.method3();
        }
    }
}

