using System;

namespace visual_studio
{
    
    public class Overload
    {
        public void add(int a,int b)
        {
             Console.WriteLine(a+b);
            
        }
        public void add(int a,int b,int c)
        {
            Console.WriteLine(a+b+c);
        }
    }

}

