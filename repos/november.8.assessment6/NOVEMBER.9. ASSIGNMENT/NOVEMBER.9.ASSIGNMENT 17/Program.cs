using System;

namespace NOVEMBER._9.ASSIGNMENT_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // WRITE AN EXPRESSION THAT CHECKS WHETHER THE third bit IN A GIVEN INTEGER IS 1 OR 0.
             int p;
             p = 452;

             bool thirdBit = (p & 8) != 0;
             Console.WriteLine($"{ thirdBit}"); 


        }
    }
}
