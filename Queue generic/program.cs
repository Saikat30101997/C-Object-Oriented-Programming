using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        Queue<string> numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        numbers.Enqueue("five");

        Console.WriteLine(numbers.Contains("one"));

        string[] s = new string[6];
        s[0] = "a";
        s[1] = "b";
        s[2] = "c";
        s[3] = "d";
        s[4] = "e";
        numbers.CopyTo(s, 1);  //numbers er element gula s array ek number index theke copy korbee
        foreach(var item in s)
        {
            Console.WriteLine(item);
        }

        numbers.Dequeue(); //retrrieve top element
        Console.WriteLine(numbers.Peek()); //show top ele in queue



       
    }
}

