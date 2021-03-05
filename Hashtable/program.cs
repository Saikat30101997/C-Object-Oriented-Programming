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
            Hashtable ht = new Hashtable();
            ht.Add("Id", 11608020);
            ht.Add("Name", "Saikat");
            ht.Add("Salary", 25000.00);
            ht.Add("Designation", "Junior Software Engineer");
            Console.WriteLine(ht["Designation"]);
            Console.ReadLine();

            Hashtable h1 = new Hashtable()
            {
                {"Id",11608020 },
                {"Name","Saikat" },
                {"Designation","Jr.Software Engineer"}
            };
       
            

            foreach(object key in ht.Keys)
            {
                Console.WriteLine(key); // random keys return koree
            }
            foreach(object key in ht.Keys)
            {
                Console.WriteLine("key: "+key+" value "+ht[key] );
            }

            Console.ReadKey();

            Console.WriteLine(ht.ContainsKey("Designation"));
            Console.WriteLine(ht.ContainsValue(11608020));
           
        }
    }
}
