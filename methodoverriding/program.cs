using System;  
using System.Collections.Generic;
namespace visual_studio
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
           
           
           Teacher t1=new Teacher();
           t1.name="Saikat";
           t1.age=24;
           t1.Qualif="B.SC. Engineering";
           t1.displayInfo();
           
           Person p1=new Person();
           p1.name="Tushar";
           p1.age=25;
           p1.displayInfo();
           Console.WriteLine(t1 is Person);

        }
     }  
}  