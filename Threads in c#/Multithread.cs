using System;
using System.Threading;

namespace Multi_threadingDemo
{
    
    class Program
    {
        public static void func1() //thread 1 e add krobo
        {
            for (int i = 1; i <=50; i++)
            {
                Console.WriteLine("Fun1 "+i+"\n");
            }
        }

        public static void func2() // thread 2 e add korbo 
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Fun2 " + i + "\n");
                if(i==25)
                {
                    Console.WriteLine("Thread is going to sleep for 8 sec.. ");
                    Thread.Sleep(8000); // i==25 hobe tokhn 8 sec er jonno fun2 ta sleep hobe.. jehetu amr fun 2 er por fun3 ache tai amar full 8 sec por abr code execute kora start korbee
                }
            }
        }

        public static void func3() // thread 3 e add korbo.. 
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Fun3 " + i + "\n");
            }
        }
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread; //currwent thread er fun
            t.Name = "Main Thread";
            Console.WriteLine(t.Name);
            Console.WriteLine(Thread.CurrentThread.Name); //j thread name create seta k amra t.name ba Thread.CurrentThread.Name  diye call korte pari..
            /*
             * egula k ami multi thread e use korbo
            Program.func1(); 
            Program.func2();
            Program.func3();
            */

            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);

            t1.Start();// start diye thread gular execution start korte hy
            t2.Start();
            t3.Start();

        }
    }
}

/* eta only ekta thread er jonno jodi kokhno amdr ekta fun er kaj sleep kore dey tahole jekhane sleep korechi tar porer gular execution wait korte thakbe 
 * r ejoono use korte hobe multithreading
 threads amdr operating system er madhome execute hy and time share koree... 
threads executed simultaneously

What is Thread?
Generally, a Thread is a lightweight process. In simple words, we can say that a Thread is a unit of a process that is responsible for
executing the application code. So, every program or application has some logic or code and to execute that logic or code, Thread comes into the picture.

By default, every process has at least one thread which is responsible for executing the
application code and that thread is called as Main Thread. So, every application by default is a single-
threaded application.

Note: All the threading related classes in C# belong to the System.Threading namespace.

ami j fun2 te sleep disi onno knu thread e affect korbe na.. 

r thread gula Operating system er iccha onujayi time share kore kaj kore run korale dekha jabe func gulu sequence vabe run 
hoobe naa .. ultapalta OS er time sequence share onusare hobe

c# e by default single thread ba main thread auto create hy 

CurrentThread():gives a reference to the currently executing thread.
Thread.Sleep():pause for some time

multitask e multithreading use kora jabe single task e multithreading use kora jabe naa
 */