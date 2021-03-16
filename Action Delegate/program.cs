using System;

namespace Delegates
{

    class Program { 
    
        static void Main(string[] args)
        {
            //Anonymus function diye
            Action<int,int> A = delegate (int a, int b) { int p = a + b; Console.WriteLine(p); };
            A.Invoke(10, 20);
            // Lambda Expression diye
            Action<int, int> A1 = (a, b) => Console.WriteLine(a + b);
            A1.Invoke(10, 20);
            //

        }
    }

}

/*Action delegate e sudu input type variable thake return type knu kichu use hobe na*/