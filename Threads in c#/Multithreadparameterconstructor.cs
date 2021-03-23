using System;
using System.Threading;

namespace Multi_threadingDemo
{
    
    class Program
    {
        public static void  func1(object max) //thread 1 e add krobo ekhane ami object max
                                              //nilam parameterzed constructor use korbo r void type hobe
                                              //karon thread er j delegates use korse ta void typer
        {

            int num = Convert.ToInt32(max);
            for (int i = 1; i <=num; i++)
            {
                Console.WriteLine("Func1 "+i+"\n ");
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
            Console.WriteLine(Thread.CurrentThread.Name); //j thread name create seta k amra t.name ba
                                                          //Thread.CurrentThread.Name  diye call korte pari..
            /*
             * egula k ami multi thread e use korbo
            Program.func1(); 
            Program.func2();
            Program.func3();
            */
            
           
            Thread t1 = new Thread(Program.func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);

            t1.Start(6);// start diye thread gular e
                        // xecution start korte hy ekhane 6 holo lenght jeta 1st func e
                        // ami object e max nisilam seta length hisebe convert
            t2.Start();
            t3.Start();

        }
    }
}

