using System;

namespace ASSESSMENT_ON_METHOD_NO_4
{
    class Program
    {

        static void Main(string[] args)
        {
            //  Write a method that finds how many times certain number can be
            //found in a given array.Write a program to test that the method works
            //correctly.

            Console.WriteLine("Enter your array length: ");
            int lengthOfArray = int.Parse(Console.ReadLine());

            int[] arr = new int[lengthOfArray];

            for(int k = 0; k < arr.Length; k++)
            {
                Console.Write("Enter the element of array:  ", k);
                arr[k] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter a number: ");
            int yourNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine( "{0}  can be found {1} times ", yourNumber,  myNumber(yourNumber, arr));

        }
        static int myNumber (int yourNumber, int[]arr)
        {
            int myCounter = 0;
            
            for(int k = 0; k < arr.Length; k++)
            {
                if(yourNumber == arr[k])
                {
                    myCounter++;
                     
                }
            }
            return myCounter;
        }
    }
}
