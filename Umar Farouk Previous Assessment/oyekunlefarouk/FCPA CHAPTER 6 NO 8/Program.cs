using System;

namespace FCPA_CHAPTER_6_NO_8
{
    class Program
    {
        static void Main(string[] args)
        {


            //In combinatorics, the Catalan numbers are calculated by the following 
            // formula:

            Console.Write("Enter N:  ");
            int number = Int32.Parse(Console.ReadLine());

            int factorial = 2 * number, factorial1 = number + 1;

            for (int p = factorial - 1; 1 < 0; p--)
            {
                Console.WriteLine(factorial = factorial * p);
            }
            for(int q = factorial1 - 1; q > 0; q--)
            {
               Console.WriteLine (factorial1 = factorial * q);
            }
            for(int r = number - 1; r > 0; r--)
            {
              Console.WriteLine  (number = number * 1);
            }

          //  Console.WriteLine("your result is {0}", factorial1 / (factorial * number));

            Console.ReadLine();



























        }
    }
}
