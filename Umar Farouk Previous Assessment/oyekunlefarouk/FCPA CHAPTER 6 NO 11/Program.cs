using System;

namespace FCPA_CHAPTER_6_NO_11
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program that calculates with how many zeroes the factorial of
            //a given number ends. Examples:
                    //  N = 10->N! = 3628800-> 2
                //N = 20->N! = 2432902008176640000-> 4



            Console.Write("Enter N: ");
            decimal n = Int32.Parse(Console.ReadLine());
            int zero = 0;

            for (int p = (int)  n - 1; p > 0; p-- )
            {
                n = n * p;
            }

            Console.WriteLine("N! is {0} and it ends with ", n);

            do
            {
                n = n / 10;
                zero++;
            }
            while (n % 10 == 0);
            {
                Console.WriteLine("{0} zero.", zero);
            }

            Console.ReadLine();



























        }
    }
}
