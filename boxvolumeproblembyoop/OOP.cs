using System;

namespace visual_studio
{
    
    public class box_volume
    {
        public double width,height,depth;
        public box_volume(double w,double h,double d)
        {
            width=w;
            height=h;
            depth=d;
        }
        public box_volume(double w,double h)
        {
            width=w;
            height=h;
        }
        public void display()
        {
             double vol=width*height*depth;
             Console.WriteLine("Volume: "+vol);

        }
        public void Areadis()
        {
            double area=width*height;
            Console.WriteLine("Area "+area);
        }
    }

}

