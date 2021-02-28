using System;
namespace visual_studio
{
    public class B:A
    {
        public int x=5;
        public void display()
        {
            Console.WriteLine(base.x);
            Console.WriteLine(x);
        }
    }
}