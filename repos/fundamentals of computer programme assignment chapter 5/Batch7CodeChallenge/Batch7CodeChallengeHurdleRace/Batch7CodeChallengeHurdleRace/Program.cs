using System;

namespace Batch7CodeChallengeHurdleRace
{
    class Program
    {
        static int hurdleRace (int k, int[] height)
        {
            int max = height[0];

            for(int i = 1; i < height.Length; i++)
            {
                if(height[i] > max)
                {
                    max = height[i];
                }
            }
            return Math.Max(0, max - k);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
