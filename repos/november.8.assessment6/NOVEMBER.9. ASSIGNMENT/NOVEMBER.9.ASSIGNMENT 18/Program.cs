using System;

namespace NOVEMBER._9.ASSIGNMENT_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // WRITE AN EXPRESSION THAT CALCULATES THE area of a trapezoid BY GIVEN SIDES a, b, AND HEIGHT h.
            double a = 66;
            double b = 27;
            double h = 18;

            double trapezoid = (a + b) * h / 2;
            Console.WriteLine($"{trapezoid}");
        }
    }
}
