using System;

namespace visual_studio
{
       class Program
    {
        static void Main(string[] args)
        {
         box_volume box=new box_volume(10,20,30);
         box.display();
         box_volume box1=new box_volume(10,20);
         box1.Areadis();
        }
    }
}
