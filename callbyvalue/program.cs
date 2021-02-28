using System;

namespace visual_studio
{
       class Program
    {
        static void Main(string[] args)
        {
           Callbyvalue c = new Callbyvalue();
           int x=20;
           Console.WriteLine(x);
           c.change(x);
           
        }
    }
}
