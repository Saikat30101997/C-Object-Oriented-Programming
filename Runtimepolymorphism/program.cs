using System;
using System.Collections;
using System.Collections.Generic;

namespace lambda
{
     class Parent
    {
        public virtual void print()
        {
            Console.WriteLine("this is in class Parent");
        }
    }
    class Child:Parent
    {
        public override void print()
        {
            Console.WriteLine("This is in Class Child");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.print();
            p = new Child();
            p.print();
           
        }
    }

}

