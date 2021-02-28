using System;

namespace visual_studio
{
       class Program
    {
        static void Main(string[] args)
        {
           Teacher teacher1=new Teacher();
           teacher1.printfn();
           Teacher teacher2=new Teacher("Saikat","Male");
           teacher2.printfn();
           Teacher teacher3=new Teacher("Saikat Das","Male",24);
           teacher3.printfn();
           
        }
    }
}
