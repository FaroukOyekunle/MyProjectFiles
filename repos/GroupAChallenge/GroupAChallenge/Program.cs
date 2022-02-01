using System;
using System.Collections.Generic;
using System.IO;

namespace GroupAChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question number one:


            int T = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < T; i++)
            {
                string input = Console.ReadLine();
                int N = Convert.ToInt32(input);
                int counter = 0;

                for(int j = 0;j < input.Length; j++)
                {
                    int output = Convert.ToInt32(input.Substring(j, 1));
                    
                    if(output != 0 && N % output == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter.ToString());
            }



            //Question Number Two

           /* int[] firstArray = { 4, 5, 6, 5, 4 };
            Console.WriteLine(MinimumDistance(firstArray));

            int[] secondArray = { 2, 4, 3, 5, 3, 1 };
            Console.WriteLine(MinimumDistance(secondArray));

            int[] thirdArray = { 2, 3, 2, 5, 2 };
            Console.WriteLine(MinimumDistance(thirdArray));   */
        }
       public static int MinimumDistance(int[] a)
        {
            Dictionary<int, int> difference = new Dictionary<int, int>();
            int minDistance = Int32.MaxValue;
            int preIndex = 0;
            int curIndex = 0;

            for(int i = 0; i < a.Length; i++)
            {
                if(difference.ContainsKey(a[i]))
                {
                    curIndex = i;

                    preIndex = difference[a[i]];

                    minDistance = Math.Min((curIndex - preIndex), minDistance);
                }
                if(!difference.ContainsKey(a[i]))
                {
                    difference.Add(a[i], i);
                }
                else
                {
                    difference[a[i]] = i;
                }
            }
            return (minDistance == Int32.MaxValue ? -1 : minDistance);
        }
    }
}
