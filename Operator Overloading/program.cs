using System;
using System.Collections;
using System.Collections.Generic;

namespace lambda
{
    public class NewClass
    {
        public int num;
        public string name;

        public static NewClass operator +(NewClass obj1,NewClass obj2)
        {
            NewClass obj3 = new NewClass();
            obj3.num = obj1.num + obj2.num;
            obj3.name = obj1.name + obj2.name;
            return obj3;

        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            NewClass obj1 = new NewClass();
            NewClass obj = new NewClass();
            obj.num = 5;
            obj1.num = 10;
            obj.name = "Saikat";
            obj1.name = "Das";

            NewClass n = new NewClass();
            n = obj + obj1;

            Console.WriteLine(n.num);
            Console.WriteLine(n.name);


        }
    }

}

