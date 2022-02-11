using System;

namespace NOVEMBER._9.ASSIGNMENT_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 5;
            int k = 10;

            f = f + k;
             k = f - k;
            f = f - k;

            Console.WriteLine($"f = {f} k = {k}");
        }
    }
}
