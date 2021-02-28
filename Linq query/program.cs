using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L = new List<int>();
            for(int i = 1;i <= 100;i++)
            {
                L.Add(i);
            }
            var q = from s in L where s >= 50 && s <= 100 select s;
            q.ToList();
            foreach(var item in q)
            {
                Console.WriteLine(item);
            }


        }
    }
}
