using System;
using System.Collections.Generic;

namespace DependecyInkection
{

    public interface iservice
    {
        List<Employee> selectEmployees();
    }
  public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

    public class EmployeeList:iservice
    {
        public List<Employee> selectEmployees()
        {
            List<Employee> listemp = new List<Employee>();
            listemp.Add(new Employee() { Id = 1, Name = "Saikat", Department = "Software Engineer" });
            listemp.Add(new Employee() { Id = 2, Name = "Shweta", Department = "IT Representive" });
            return listemp;
        }
    }

    public class EmployeeListshow 
    {
        //public EmployeeList em1;
        public iservice isv;
        public EmployeeListshow(iservice iservice)
        {
            this.isv = iservice;
        }

        public List<Employee> show()
        {
            return isv.selectEmployees();
        }


        
    }
   class Program {
        static void Main(string[] args)
        {
            EmployeeListshow em = new EmployeeListshow(new EmployeeList());
            List<Employee> emp1 = em.show();
            foreach(Employee emp in emp1)
            {
                Console.WriteLine(emp.Id+" "+emp.Name+" "+emp.Department);
            }


        }
    }
}

/*
 The Dependency Injection is a design pattern that allows us to develop loosely coupled software components. In other words, we can say that this design pattern is
used to reduce the tight coupling between the software components. As a result, we can easily manage future changes and other complexity in our application.

Before understanding the Dependency Injection Design Pattern using C#, first, we need to understand what is tight 
coupling and what is loose coupling in software development. So let’s understand these two concepts first.


What is Tight Coupling in Software Design?
Tight coupling means classes and objects are dependent on each other. That means when a class is dependent 
on another concrete class, then it is said to be a tight coupling between these two classes. In that case, 
if we change the dependent object, then we also need to change the classes where this dependent object is used. 
If your application is a small one, then it is not that difficult to handle but 
if you have a big enterprise-level application, then its really very difficult to handle to make these changes.

What is Loose Coupling in Software Design?
Loosely coupling means two objects are independent of each other. That means if we
change one object then it will not affect another object. The loosely coupled nature of software development 
allows us to manage future changes easily and also allows us to manage the complexity of the application.
Dependency Injection pattern involves 3 types of classes:

Client Class: The Client class (dependent class) is a class that depends on the service class.
Service Class: The Service class (dependency) is a class that provides service to the client class.
Injector Class: The Injector class injects the service class object into the client class.

Different Types of Dependency Injection in C#?
The injector class injects the dependency object to a class in three different ways. They are as follows.

Constructor Injection: When the Injector injects the dependency object (i.e. service) through 
the client class constructor, then it is called as Constructor Injection.

Property Injection: When the Injector injects the dependency object (i.e. service) through the public 
property of the client class, then it is called as Property Injection. This is also called as the Setter Injection.


 
Method Injection: When the Injector injects the dependency object (i.e. service) 
through a public method of the client class, then it is called as Method Injection. 
In this case, the client class implements an interface that declares the method(s) to supply the dependency object 
and the injector uses this interface to supply the dependency object (i.e. service) to the client class.
 

this code is constructor injection


amdr ekta class er upor r ekta class er depend kore kaj korar jonno eta use kri..
 */
