using System;
using static System.Console;
using System.Linq;

namespace Batch7CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
{
           /* var numbers = ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();
            var sumOfAllNumbers = 0L;
            var minimum = long.MaxValue;
            var maximum = 0L;
            for (int i = 0; i < 5; i++)
            {
                sumOfAllNumbers += numbers[i];
                if (numbers[i] < minimum)
                    minimum = numbers[i];

                if (numbers[i] > maximum)
                    maximum = numbers[i];
            }
            Console.WriteLine(string.Format("{0} {1}", sumOfAllNumbers - maximum, sumOfAllNumbers - minimum));*/
        } 
        /* public static void MiniMaxSum(int [] arr1)
         {
            long A, B, C, D, E;

             A = (long)arr1[1] + (long)arr1[2] + (long)arr1[3] + (long)arr1[4];
             Console.WriteLine(A);

             B = (long)arr1[0] + (long)arr1[2] + (long)arr1[3] + (long)arr1[4];
             Console.WriteLine(B);

             C = (long)arr1[0] + (long)arr1[1] + (long)arr1[3] + (long)arr1[4];
             Console.WriteLine(C);

             D = (long)arr1[0] + (long)arr1[1] + (long)arr1[2] + (long)arr1[4];
             Console.WriteLine(D);

             E = (long)arr1[0] + (long)arr1[1] + (long)arr1[2] + (long)arr1[3];
             Console.WriteLine(E);

             long[] minArray = new long[] { A, B, C, D, E };

             long MAX = minArray[0];
             for(int i = 0; i < minArray.Length; i++)
             {
                 if(minArray[i] > MAX)
                 {
                     MAX = minArray[i];
                 }
             }
             long MIN = minArray[0];
             for(int i = 0; i < minArray.Length; i++)
             {
                 if(minArray[i] < MIN)
                 {
                     MIN = minArray[i];
                 }
             }
             Console.WriteLine(MIN + "" + MAX);
             Console.ReadKey();
         } */



        
    }
}
