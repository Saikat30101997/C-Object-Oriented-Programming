using System;  
using System.Collections.Generic;
namespace visual_studio
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
           Person p1=new Person();
           
           Teacher t1=new Teacher();
           t1.setn("Saikat");
           t1.seta(25);
           t1.Qualif="B.SC. Engineering";
           t1.display1();

        }
     }  
}  