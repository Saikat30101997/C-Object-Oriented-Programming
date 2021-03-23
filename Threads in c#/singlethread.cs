using System;
using System.Threading;

namespace Multi_threadingDemo
{
    
    class Program
    {
        public static void func1()
        {
            for (int i = 1; i <=50; i++)
            {
                Console.WriteLine("Fun1 "+i+"\n");
            }
        }

        public static void func2()
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

        public static void func3()
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

            Program.func1();
            Program.func2();
            Program.func3();

        }
    }
}

/* eta only ekta thread er jonno jodi kokhno amdr ekta fun er kaj sleep kore dey tahole jekhane sleep korechi tar porer gular execution wait korte thakbe 
 * r ejoono use korte hobe multithreading*/