using System;

namespace FCPA_CHAPTER_7_NO_6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program, which finds the maximal sequence of increasing
            //elements in an array arr[n].It is not necessary the elements to be
            //consecutively placed.E.g.: { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  { 2, 4, 6, 8}.

            int counter = 0;
            int index;
            int temporaryCounter;

            Console.Write(" enter the length of your array: ");
            int arrayLength = Int32.Parse(Console.ReadLine());

            int[] arr = new int[arrayLength];
            int[] result = new int[arrayLength];

            for(int i = 0; i < arrayLength; i++)
            {
                Console.Write(" enter your element in the array ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for(int i = 0; i < arrayLength; i++)
            {
                int[] temporaryResult = new int[arrayLength];
                index = temporaryCounter = 1;
                temporaryResult[0] = arr[i];
            }

            for(int k = + 1; k < arrayLength; k++ )
            {
                if(arr[j] > temporaryResult[index - 1])
                {
                    temporaryResult[index] = arr[k];
                    index++;
                    temporaryCounter++;
                }
                else if
            }



























        }
    }
}
