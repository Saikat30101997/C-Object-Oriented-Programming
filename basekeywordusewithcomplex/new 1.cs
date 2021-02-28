using System;
namespace visual_studio
{
    public class Car:Vehicle
    {
        public int gear;
        public Car(string c,double w,int g):base(c,w)
        {
            gear=g;
        }
    public override void attribute()
    {
        base.attribute();
        Console.WriteLine("Gear: "+gear);

    }
    }
    
}