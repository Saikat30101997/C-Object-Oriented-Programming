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
/*
Extension methods must be defined only under the static class.
As an extension method is defined under a static class, compulsory that the method should be defined as static whereas once the method is bound with another class, the method changes into non-static.
The first parameter of an extension method is known as the binding parameter which should be the name of the class to which the method has to be bound and the binding parameter should be prefixed with this keyword.
An extension method can have only one binding parameter and that should be defined in the first place of the parameter list.
If required, an extension method can be defined with a normal parameter also starting from the second place of the parameter list. */


