using System;

namespace visual_studio
{
    
   public class Person
    {
      private string name;
       private int age;
       public void setn(string name)
       {
          this.name=name;
          
       }
       public string getn()
       {
          return name;
       }
       public void seta(int age)
       {
          this.age=age;
       }
       public int geta()
       {
          return age;
       }

       public void display()
       {
          Console.WriteLine("Name: "+name);
          Console.WriteLine("Age: "+age);

       }
      
    }

}

