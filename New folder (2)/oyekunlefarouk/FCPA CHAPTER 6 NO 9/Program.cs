using System;

namespace FCPA_CHAPTER_6_NO_9
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Write a program that for a given integers n and x, calculates the sum: 


            int sum = 1;
            int factorial = 1;

            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter X: ");
            int x = Int32.Parse(Console.ReadLine());

            for(int p = 1; p <= n; p++)
            {
                factorial = factorial * p / x;
                sum = sum + factorial;
            }

            Console.WriteLine("your result {0}", sum);

            Console.ReadLine();































        }
    }
}
