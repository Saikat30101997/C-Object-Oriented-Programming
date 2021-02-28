using System;

 

namespace visual_studio

{

   
    class Program

    {

        static void Main(string[] args)

        {
           Shape s;
           s=new Triangle(10,15);
           s.area();
           s=new Rectangle(30,40);
           s.area();
           s=new Circle(11);
           s.area();
        }

    }

}