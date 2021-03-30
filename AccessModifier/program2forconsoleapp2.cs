using System;
using Accessmodifiers1;

namespace Accessmodifier2
{
    class Program2:class1
    {
        static void Main(string[] args)
        {
            class1 c = new class1();
            Program2 p = new Program2();
            ////c.show(); error dekhabe 
            //// p.show(); error dekhabe
            ////c.show1(); error dekhabe
            p.show1(); //cause protected error dekhabe naa
            //c.show2();//error dekhabe
            //p.show2();//error dekhabe

        }
    }
}
