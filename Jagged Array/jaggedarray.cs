using System;
using System.Collections.Generic;

namespace DependecyInkection
{

   
   class Program {

        public int Answer(int[][]edges)
        {

            int L = edges.GetLength(0); // eta length of height r lenght of  width edges.GetLength(1)
            int first = edges[0][0];
            int second = edges[0][1];
            int cnt = 0, cnt1 = 0;
            for(int i=1;i<L;i++)
            {
                for(int j=0;j<2;j++)
                {
                    if (edges[i][j] == first) cnt++;
                    else if (edges[i][j] == second) cnt1++;
                }
            }

            if (cnt > cnt1) return first;
            else return second;



        }
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
            new int[]{1,2},       // prottek ta array k initialize korsi ekta single array r moto
            new int[]{2,3},
            new int[] {3,4 }
            };
            Program p = new Program();
            Console.WriteLine(p.Answer(arr));
            
           

        }
    }
}

