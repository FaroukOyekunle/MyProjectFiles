using System;

namespace WEEKLY_ASSESSMENT_BATCH_7_NO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //  (Find the smallest element) Write a method that finds the smallest element in an array of double values using the following header:
            double[] myNumber = new double[10];
            for(int i = 0; i < myNumber.Length; i++)
            {
                Console.WriteLine(" Enter your preferred ten integers. ");
                int yourInput = int.Parse(Console.ReadLine());

                myNumber[i] = yourInput;
            }

            Console.WriteLine(" your minimum integer is: " + minimum(myNumber));
        }
        static double minimum (double[] array)
        {
            double minimum = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(minimum > array[i])
                {
                    minimum = array[i];
                }
            }
            return minimum;
        }
    }
}
