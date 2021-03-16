using System;
using System.Collections.Generic;

namespace Delegates
{

    class Program { 
       public static bool Ischeck(string n)
        {
            if (n.StartsWith("S"))
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            List<string> L = new List<string>();
            L.Add("Saikat");
            L.Add("Shweta");
            L.Add("Tondra");
            L.Add("Tushar");
            L.Add("Nil");

            Predicate<string> p ;
            p = Ischeck;
            var data = L.FindAll(p);
            foreach(var item in data)
            {
                Console.WriteLine(item);
            }

            Predicate<string> P = delegate (string a)
            {
                if (a == "Saikat") return true;
                else return false;
            };
            Console.WriteLine(p.Invoke("Shweta"));

            //lambda expression 
            Predicate<string> p2 = Ischeck;
            p2 = x => x.StartsWith("S");
            var data1 = L.FindAll(p2);
            foreach(var item in data1)
            {
                Console.WriteLine(item);
            }

            
        }
    }

}

/*Predicate Delegate amdr input type parameter pass kore ekta criteria onusare check dite pare j criteria fulfill korte parche kina*/