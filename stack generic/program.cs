using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        Stack<string> numbers = new Stack<string>();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");

       
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nPopping '{0}'", numbers.Pop()); // top element jeta pop korbeee
        Console.WriteLine("Peek at next item to destack: {0}",
            numbers.Peek()); // top element in stack
        Console.WriteLine("Popping '{0}'", numbers.Pop());

       
        Stack<string> stack2 = new Stack<string>(numbers.ToArray()); // ekta new stack e arekta stack element copy bt 1st e oi stack k array te convert koree nitee hobee

        Console.WriteLine("\nContents of the first copy:");
        foreach (string number in stack2)
        {
            Console.WriteLine(number);
        }

       
        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2, numbers.Count); // array te numbers.count joto thk toto index theke numbers stack er element copy kortse 

        Stack<string> stack3 = new Stack<string>(array2); // array ta abar new ekta stack e copy kora hoyeche stack to stack copy koraa jay naaa

        Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
        foreach (string number in stack3)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
            stack2.Contains("four"));  // four contain kortse ki naa check koreee

        Console.WriteLine("\nstack2.Clear()");
        stack2.Clear();
        Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
    }
}

