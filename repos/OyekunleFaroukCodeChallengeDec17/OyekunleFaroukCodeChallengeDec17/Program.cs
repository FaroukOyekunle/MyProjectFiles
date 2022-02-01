using System;

namespace OyekunleFaroukCodeChallengeDec17
{
    class Program
    {
        public static int WholeDifference (int [,] Totalarr, int nth)
        {
            int firstNumber = 0; 
            int secondNumber = 0;

            for(int x = 0; x < nth; x++)
            {
                for(int y = 0; y < nth; y++)
                {
                    if (x == y)
                        firstNumber += Totalarr[x, y];

                    if (x == nth - y - 1)
                        secondNumber += Totalarr[x, y];
                }
            }
            return Math.Abs(firstNumber - secondNumber);
        }
        static void Main(string[] args)
        {
            int nth = 4;

            int[,] SumOfarr = { { 10, 5, 8,4},
                              { 8, 3, 9,9 },
                              {4, 2, 8,9 },
                              {5, 4, 2,1 }
            };
            Console.Write(WholeDifference(SumOfarr, nth));
            Console.ReadKey();
        }
    }
}
