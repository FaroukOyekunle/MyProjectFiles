using System;

namespace FCPA_CHAPTER_7_NO_19
{
    class Program
    {
        static void Main(string[] args)
        {

           // Write a program, which finds all prime numbers in the range
            //[1…10, 000, 000].


            for(int p = 2; p < 10000000; p++)
            {
                bool isPrime = true;
                for(int k = 2; k <= p / 2; k++)
                {
                    if(p % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.WriteLine($"{p} \n ");
                }
            }































        }
    }
}
