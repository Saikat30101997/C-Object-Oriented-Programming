using System;
using System.Threading;
using System.Threading.Tasks;
namespace TaskBasedAsynchronousProgramming
{
    class Program
    {
       public static async Task PrintCounter(int a,int b) // method ta k asynchronous banacchi async then pore task likhte hy
        {
            // Console.WriteLine("This is my second program");

            await Task.Run(() => { Console.WriteLine(a + b); }); // return korar jonno use hobe Task.Run 

        }
        static void Main(string[] args)
        {
           Console.WriteLine("1st");
           Console.WriteLine("2nd");

            PrintCounter(10,15);

            Console.WriteLine("3rd");
            Console.ReadLine();
        }
       
    }
}
/* prothome 1st 2nd 3rd then sum run korbe cz async er jonno onno method gula wait korbe naa*/

