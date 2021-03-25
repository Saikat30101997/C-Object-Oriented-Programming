using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RealLifeExampleDelegates
{

    public delegate bool PerfectForPromotion(Employee emp);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Experience { get; set; }
        public int Salary{ get; set; }

        public static void Promotion(List<Employee> Emp, PerfectForPromotion p)
        {
            foreach(Employee emp in Emp)
            {
                if(p(emp))
                {
                    Console.WriteLine("Employee Name: {0} Salary: {1} is Promoted",emp.Name,emp.Salary);
                }
            }
            {

            }
        }
       
    }

   
    class Program
    {

        public static bool Promoted(Employee emp)
        {
            if (emp.Salary<=30000) return true;
            else return false;
        }

        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                Id = 1,
                Name="Saikat Das Tushar",
                Department="Jr. Software Engineer ASP.NET Core MVC",
                Gender="Male",
                Experience="1 Year",
                Salary=30000
            
            };

            Employee emp2 = new Employee()
            {
                Id = 2,
                Name = "Sohel Arman",
                Department = "Jr. Software Engineer in ASP.NET Core Web API",
                Gender = "Male",
                Experience = "1 Year",
                Salary = 40000

            };

            Employee emp3 = new Employee()
            {
                Id = 1,
                Name = "Rakib Islam",
                Department = "Jr. Software Engineer in SQA",
                Gender = "Male",
                Experience = "1 Year",
                Salary = 33000

            };

            Employee emp4 = new Employee()
            {
                Id = 1,
                Name = "Uttirna Talukder Shweta",
                Department = "Assitant Manager In HR",
                Gender = "FeMale",
                Experience = "1 Year",
                Salary = 60000

            };

            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);

            PerfectForPromotion perfectForPromotion = new PerfectForPromotion(Program.Promoted);

            Employee.Promotion(employees, perfectForPromotion);


        }
       
    }
}


