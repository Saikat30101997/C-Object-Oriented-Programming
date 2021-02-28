using System;
namespace visual_studio
{
    public class Teacher:Person
    {
        public String Qualif;
        
        public void displayInfo() 
        {
            
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Qualification: "+Qualif);
        }
    }
}