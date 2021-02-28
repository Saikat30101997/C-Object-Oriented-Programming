using System;

namespace visual_studio
{

    public class Student
    {
       string name;
       int Id;
       static string universityname="Comilla University";

       public Student(string name,int Id)
       {
           this.name=name;
           this.Id=Id;
       }
       public void display()
       {
           Console.WriteLine("Name: "+name);
           Console.WriteLine("Roll: "+Id);
           Console.WriteLine("Unversity name: "+universityname);
       }
    }
}

