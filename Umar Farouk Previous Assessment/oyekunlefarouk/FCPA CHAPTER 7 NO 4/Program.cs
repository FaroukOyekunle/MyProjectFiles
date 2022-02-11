using System;

namespace FCPA_CHAPTER_7_NO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which finds the maximal sequence of consecutive
            //equal elements in an array. E.g.: { 1, 1, 2, 3, 2, 2, 2, 1}  { 2, 2, 2}.


            int firstCount = 1;
            int temporaryCount = 1;
            int number = 0;

            Console.Write("Enter your array length ");
            int lengthOfArray = Int32.Parse(Console.ReadLine());
            int[] arr = new int[lengthOfArray];

            for(int k = 0; k < arr.Length; k++)
            {
                Console.Write("Enter element in: ", k);
                arr[k] = Int32.Parse(Console.ReadLine());
            }

            for(int a = 0; a < arr.Length - 1; a++)
            {
                if(arr[a] == arr[a + 1])
                {
                    temporaryCount++;
                }
                else
                {
                    temporaryCount = 1;
                }

                if(temporaryCount > firstCount)
                {
                    firstCount = temporaryCount;
                    number = arr[a];
                }
            }

            for(int b = 0; b< firstCount; b++)
            {
                Console.Write(number);
            }




































        }
    }
}
