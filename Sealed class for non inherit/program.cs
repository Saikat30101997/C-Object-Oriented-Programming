using System;

 

namespace visual_studio

{

  

    sealed class Users

    {

        public string name = "Saikat Das Tushar";

        public string location = "Comilla";

        public void GetInfo()

        {

            Console.WriteLine("Name: {0}", name);

            Console.WriteLine("Location: {0}", location);

        }

    }

    // Derived Class

    public class Details

    {

        public int age = 32;

        public void GetAge()

        {

            Console.WriteLine("Age: {0}", age);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {
           Users u= new Users();
           u.GetInfo();

            Details d = new Details();

            d.GetAge();

        }

    }

}