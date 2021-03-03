using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;



namespace visual_studio

{
    public class Student
    {
        public string Name { get; private set; }
        public int id { get; private set; }
        public string department { get; private set; }

        public Student(string n, int i, string d)
        {
            Name = n;
            id = i;
            department = d;
        }

    }

    class Program

    {

        static void Main(string[] args)
        {
            Student std = new Student("Saikat Das", 11608020, "CSE");
            Student std1 = new Student("Arman Hossain", 11608022, "CSE");
            Student std2= new Student("Rakib Islam", 11608008, "CSE");
            List<Student> stdlist = new List<Student>();
            stdlist.Add(std);
            stdlist.Add(std1);
            stdlist.Add(std2);

            foreach(var Student in stdlist)
            {
                Console.WriteLine("Student name: {0} Student ID: {1} Department: {2}", Student.Name, Student.id, Student.department);
            }




        }

    }

}