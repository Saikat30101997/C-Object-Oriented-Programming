using System;
namespace visual_studio
{
    public class B:A
    {
        
        public void display()
        {
            base.display();
            Console.WriteLine("Inside B class");
            message();

        }
    }
}