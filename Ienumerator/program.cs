using System;
using System.Collections;
using System.Collections.Generic;

namespace lambda
{
  
    public class Student
    {
        public string name{ get; set; }
        public int id { get; set; }

        public string dept { get; set; }
    }

    public class School:IEnumerable
    {
        List<Student> S1= new List<Student> ();

        public  void Add(Student s)
        {
            S1.Add(s);
        }

        public IEnumerator GetEnumerator()
        {
            return S1.GetEnumerator();
        }
             
    }
    class Program
    {
        static void Main(string[] args)
        {

            Student std = new Student();
            std.id = 1;
            std.name = "Saikat";
            std.dept = "CSE";

            School sc = new School();
            sc.Add(std);
            foreach(Student s in sc)
            {
                Console.WriteLine("id: "+s.id+"name: "+s.name+"dept: "+s.dept);
            }
        }
    }

}

