using System;

namespace NOVEMBER._9._ASSIGNMENT_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //WRITE A PROGRAM THAT PRINTS ON THE CONSOLE THE PERIMETER AND THE AREA OF A RECTANGLE BY GIVEN SIDE AND HEIGHT ENTERED BY THE USER.
            double L = 10;
            double w = 15;

            double perimeter = 2 * (L + w);
            double area = (L * w);
            Console.WriteLine($"the perimeter of a rectangle is equal to: {perimeter}");
            Console.WriteLine($"the area of a rectangle is equal to: {area}");
        }
    }
}
