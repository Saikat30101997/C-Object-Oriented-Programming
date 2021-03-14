using System;

namespace Delegates
{
   

    class Program
    {
        public int a;
        public int  MyLogic(int a)
        {
            this.a = a;
            int p = a + 10;
            return p;
        }

        public int Myaction(Func<int,int>y,int l)
        {
            return y.Invoke(MyLogic(a)+l);
            

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int a=p.MyLogic(15);
            Func<int, int> h ;
            Console.WriteLine( p.Myaction(h = a=>a,17));
            

                
                
             
        }
    }

}

/* asole ami ki kaj ta korlm amr mylogic e j variable ta nlm  tar sate my action e j l niboo tar sate jog korboo... 
 akhn amr kaj holoo my logic ta nlm then ami myaction lambda variable er maddhoe kaj korechi.. 15+10=25 then 25+17=42 */