using System;
using System.Collections.Generic;

namespace DependecyInkection
{

   
   class Program {

        

        static void Main(string[] args)
        {
            // Declare the array of two elements.
            int[][] arr = new int[2][]; //eta diye amra only sari koyta hobe ta bole disi mane 2 ta hobe bt colu decided na

            // Initialize the elements.
            arr[0] = new int[5] { 1, 3, 5, 7, 9 }; //ekhane 0 sari te 5 ta element r 2nd ta te 4 ta
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Display the array elements.
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();



        }
    }
}

