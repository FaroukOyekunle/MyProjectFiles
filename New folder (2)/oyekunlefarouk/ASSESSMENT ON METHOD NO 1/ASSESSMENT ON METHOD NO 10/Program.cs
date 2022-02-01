using System;
using System.Numerics;

namespace ASSESSMENT_ON_METHOD_NO_10
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program that calculates and prints the n! for any n in the range
            // [1…100].

            for(int r = 1; r < 101; r++)
            {
                Console.WriteLine("{0}! = {1}", r, FactorialOfNumber(r));
            }
            
        }
        public static BigInteger FactorialOfNumber(BigInteger preferredNumber)
        {
            if (preferredNumber <= 1)
            {
                return 1;
            }

            else
            {
                return preferredNumber * FactorialOfNumber(preferredNumber - 1);
            }
        }

       /* public static double FactorialOfNumber(double preferredNumber)
        {
            if (preferredNumber <= 1)
            {
                return 1;
            }

            else
            {
                return preferredNumber * FactorialOfNumber(preferredNumber - 1);
            }
        }
*/
    }
}
