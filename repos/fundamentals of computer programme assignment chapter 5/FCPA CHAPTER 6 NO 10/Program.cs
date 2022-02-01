using System;

namespace FCPA_CHAPTER_6_NO_10
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Write a program that reads from the console a positive integer number
            //N(N < 20) and prints a matrix of numbers as on the figures below:
            //  N = 3 N = 4
            //1 2 3
            //2 3 4
            //3 4 5
            //2 3 4 5
            //3 4 5 6
            //4 5 6 7


            Console.Write("Enter N: (N < 20):     ");
            int n = Int32.Parse(Console.ReadLine());

            for(int p = 1; p <= n; p++)
            {
                for(int q = p; q <= p; q++)
                {
                    Console.Write("\n{0}", q);
                }
            }

            Console.ReadLine();




























        }
    }
}
