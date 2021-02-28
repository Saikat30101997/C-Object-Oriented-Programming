using System;

namespace visual_studio
{
    
    public class Person
    {
       private string name;
       public int age;
       public void get(string name,int age)
       {
          this.name=name;
          this.age=age;
       }
      

       public void display()
       {
          Console.WriteLine("Name: "+name);
          Console.WriteLine("Age: "+age);
       }


    }

}

