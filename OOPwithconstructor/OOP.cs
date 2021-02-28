using System;

namespace visual_studio
{

    public class Teacher
    {
       public string name,gender;
         public int age;
         public Teacher(string name,string gender,int age)
         {
             this.name=name;
             this.gender=gender;
             this.age=age;
             
         }
    
         public void printfn()
         {
             Console.WriteLine("Name: "+name);
             Console.WriteLine("Gender :"+gender);
             Console.WriteLine("Age :"+age);

         }

    }
}

