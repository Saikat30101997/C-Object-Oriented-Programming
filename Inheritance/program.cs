using System;  
using System.Collections.Generic;
namespace visual_studio
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
           Person p1=new Person();
           p1.name="Saikat";
           p1.age=25;
           p1.display();
           Teacher t1=new Teacher();
           t1.name="Tushar";
           t1.age=25;
           t1.Qualif="B.SC. Engineering(CSE)";
           t1.display1();
        }
     }  
}  