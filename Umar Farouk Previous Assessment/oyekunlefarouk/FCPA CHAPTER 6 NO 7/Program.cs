using System;

namespace FCPA_CHAPTER_6_NO_7
{
    class Program
    {
        static void Main(string[] args)
        {


            // Write a program that calculates N!*K! / (N - K)! for given N and K
            // (1 < K < N).

            Console.Write("Enter your n th: ");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.Write("Enter your k th: ");
            ulong k = ulong.Parse(Console.ReadLine());

            ulong nTHk = n - k;

            for(ulong p = n - 1; p > 0; p--)
            {
                n = n * p;
               
            }
            for (ulong q = k - 1; q > 0; q--)
            {
                k = k * q;
                
            }
            for(ulong r = nTHk - 1; r > 0; r--)
            {
                nTHk = nTHk * r;
                
            }
           
           Console.WriteLine($"your sequence outcome happens to be {n * k / nTHk}");

            Console.ReadLine();







































        }
    }
}
