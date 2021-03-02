using System.IO;
using System.Text;
using System;
namespace visual_studio
{
    public class B:A
    {
        
        public override void display()
        {

            base.display();
            Console.WriteLine("Inside B class");
            message();

        }
        public void solve(string x)
        {
            string path = @"C:\Users\Saikat Das\Desktop\New folder\Filehandling\forfilehandle.txt";
            File.WriteAllText(path,x);
        }
    }
}