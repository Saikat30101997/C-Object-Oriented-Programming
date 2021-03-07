using System;
using System.Collections;
using System.Collections.Generic;

namespace lambda
{
    public class Student
    {
        public int Id{ get; set; }
        public String Name { get; set; }
        public String Dept { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student()
            {
                Id = 1,
                Name = "Saikat",
                Dept = "CSE"
            };

            Student std1 = new Student()
            {
                Id = 2,
                Name = "Shweta",
                Dept = "Anthropology"
            };

            Dictionary<int, Student> d = new Dictionary<int, Student>();
            d.Add(std.Id, std);
            d.Add(std1.Id, std1);
            foreach(int item in d.Keys)
            {
                Console.WriteLine(item);
            }

            foreach(KeyValuePair<int,Student> s in d)
            {
                Console.WriteLine("Name: "+s.Value.Name+" "+s.Key);
            }
            Console.WriteLine(d.ContainsKey(1));
            


        }
    }

}

