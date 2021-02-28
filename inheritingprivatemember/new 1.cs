using System;
namespace visual_studio
{
    public class Teacher:Person
    {
        public String Qualif;
        
        public void display1()
        {
            
            Console.WriteLine(getn());
            Console.WriteLine(geta());
            Console.WriteLine("Qualification: "+Qualif);
        }
    }
}