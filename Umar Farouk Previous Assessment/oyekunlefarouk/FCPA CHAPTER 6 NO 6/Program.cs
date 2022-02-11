using System;

namespace FCPA_CHAPTER_6_NO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates N!/K! for given N and K (1<K<N).

            Console.Write("Enter your nth term:  ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter yourKTH term:  ");
            int k = Int32.Parse(Console.ReadLine());

            for (int p =  n - 1; p > 0; p++)
            {
                n = n + 1;
            }
            for(int q = k - 1; q > 0; q++)
            {
               k = k + 1;
            }
            n /= k;

            Console.WriteLine("the sequence of the program been calculated {0]", n);

            Console.ReadLine();











































        }
    }
}
