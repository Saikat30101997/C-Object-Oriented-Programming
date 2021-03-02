using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

 

namespace visual_studio

{
   

   
    class Program

    {
        static void Main(string[] args)
        {

            B b=new B();
           b.display();
           b.solve("Hello");
            string path = @"C:\Users\Saikat Das\Desktop\New folder\Filehandling\forfilehandle.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Found");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else 
            {
                Console.WriteLine("No");
            }
        

        
        }

    }

}