using System;

namespace visual_studio
{
    public  class Rectangle:Shape
    {
       public Rectangle(double dim1,double dim2):base(dim1,dim2)
       {     

       }
       public override void area()
       {
           Console.WriteLine(dim1*dim2);
       }
    }
    public class Triangle:Shape
    {
        public Triangle(double dim1,double dim2):base(dim1,dim2)
        {

        }
        public override void area()
        {
            Console.WriteLine(0.5*dim1*dim2);
        }
    }
    public class Circle:Shape
    {
       
       public Circle(double r):base(r,r)
       {
          
       }
       public override void area()
       {
           Console.WriteLine(3.1416*dim1*dim1);
       }
    }
}