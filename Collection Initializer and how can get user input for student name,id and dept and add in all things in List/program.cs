using System;
using System.Collections.Generic;

namespace Delegates
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Dept { get; set; }
    }
   class Program {
        static void Main(string[] args)
        {
            List<Student> std = new List<Student>()
            {
                new Student(){Id=1,Name="Saikat",Dept="CSE" },
                new Student(){Id=2,Name="Shweta",Dept="Anthropology"}
            };

            foreach (var item in std)
            {
                Console.WriteLine(item.Name+" "+item.Dept);
            }
            Console.WriteLine("\n");
            std.Add(new Student() { Id = 3, Name = "Tushar", Dept = "CSE" });

            foreach (var item in std)
            {
                Console.WriteLine(item.Name + " " + item.Dept);
            }
            Console.WriteLine("\n");
            for (int i = 1; i <= 2; i++) //ekhane input nicchi
            {
                int x = int.Parse(Console.ReadLine());
                string y = Console.ReadLine();
                string z = Console.ReadLine();

                std.Add(new Student() { Id = x, Name = y, Dept = z }); // er maddhome amra agula list e add kortee parboo

            
            }

            foreach (var item in std)
            {
                Console.WriteLine(item.Name + " " + item.Dept);
            }

        }



    }
}

