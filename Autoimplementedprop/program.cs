using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

 

namespace visual_studio

{
    public class Student
    {
        public string fName { get;  set; }
        public string lName { get; set; }
        public Student(string f,string l)
        {
            fName=f;
            lName=l;
        }
      
        
        
    }
   

   
    class Program

    {
        static void Main(string[] args)
        {
            Student st = new Student("Saikat","Das");
            Console.WriteLine(st.fName);
           

        
        }

    }

}
