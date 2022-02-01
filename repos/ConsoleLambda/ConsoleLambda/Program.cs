using System;

namespace ConsoleLambda
{
    class Program
    {
        delegate double CalArePointer(int p);
        static CalArePointer CaPointer = CalculateArea;
        static void Main(string[] args)
        {
            double Area = CaPointer.Invoke(10);
        }
        static double CalculateArea(int k)
        {
            return 66.27 * k * k;
        }
    }
}
