using System;

namespace WEEKLY_ASSESSMENT_BATCH_7_NO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //  (Factorials)Factorials are used frequently in probability problems.
            //  The factorial of a positive integer n(written n! and pronounced “n factorial”)
            //  is equal to the product of the positive integers from 1 to n.
            //  Write an app that evaluates the factorials of the integers from 1 to 5.
            //  Display the results in tabular format.
            //  What difficulty might prevent you from calculating the factorial of 20 ?



            int factorial = 1;

            for(int i = 1; i <= 5; i++)
            {
                factorial = factorial * i;
                Console.WriteLine($"{i}! \t   = {factorial} ");
            }
        }
    }
}
