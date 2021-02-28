using System;

namespace visual_studio
{
       class Program
    {
        static void Main(string[] args)
        {
             Overload fst=new Overload();
             fst.add(4,5);
             Overload scnd=new Overload();
             scnd.add(5,6,7);
        }
    }
}
