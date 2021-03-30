using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Accessmodifiers1
{
    public class class1 //class private korle error dekhay
    {
        private void show ()
        {
            Console.WriteLine("private method");
        }
        protected void show1()
        {
            Console.WriteLine("Protected Method");
        }

        internal void show2()
        {
            Console.WriteLine("internal method");

        }
    }

   
    class Program1 : class1
    {
       
        

        public static void myLogic(Func<int,int,int>func,int x,int y)
        {
            int result = func.Invoke(x,y);
            Console.WriteLine(result);
           
        }
        static void Main(string[] args)
        {
            class1 c = new class1();
            // c.show();//error dekhabe eta eccesbale na
           // c.show1();//error dekhabe
            Program1 p = new Program1();
            p.show1(); // inherit korar eta r error dekhacche na protected er jonno
            c.show2();
            //p.show2();
        }

       
    }
}
/*private application e applicable na,protected o applicable na, internal applicable
 * private current class e applicable,protected o applicable,internal o applicable
 * private derived class e applicable na,protected apllicable,internal o applicable
 * private onno namespace e applicable na,protected applicable na,internal o na
 * private onno namespace but derived class e applicable na,protected o na internal e o na
 * public shb khan e applicable */


