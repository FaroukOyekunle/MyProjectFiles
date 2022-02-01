using System;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = {0, -3, 4, -5, 3};
            int k = -3;
            int pairOne = nums.Length;

            if(PairElement(nums, pairOne, k))
            {
                Console.WriteLine("output pair exists.");
            } 
            else
            {
                Console.WriteLine("no output pair "  + k);
            }
        }
        static bool PairElement(int [] PairValueArray, int pairOne, int pairNumber)
        {
            for(int x = 0; x < (pairOne - 1); x++)
            {
                for(int y = (x + 1); y < pairOne; y++)
                {
                    if(PairValueArray[x] + PairValueArray[y] == pairNumber)
                    {
                        Console.WriteLine("FirstPair is " + pairNumber + " is  (" + PairValueArray[x] + " , " + PairValueArray[y] + ")");
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
