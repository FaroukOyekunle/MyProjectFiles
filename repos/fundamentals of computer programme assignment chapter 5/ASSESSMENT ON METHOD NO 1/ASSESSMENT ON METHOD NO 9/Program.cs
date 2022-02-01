using System;

namespace ASSESSMENT_ON_METHOD_NO_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that finds the biggest element of an array.Use that
            //method to implement sorting in descending order.

            GettingBiggestElement();

        }

        public static void GettingBiggestElement()
        {
            Console.WriteLine("Hello user, try and enter the amount of element you preferred:");
            int elementSize = int.Parse(Console.ReadLine());


            Console.WriteLine();
            int[] yourNumber = new int[elementSize];
            for(int k = 0; k < elementSize; k++)
            {
                Console.WriteLine("Enter the element of your choice: ");
                yourNumber[k] = int.Parse(Console.ReadLine());
            }
            int x = 0;

            foreach(var item in yourNumber)
            {
                for(int  z = 1; z < yourNumber.Length; z++)
                {
                    if(yourNumber[x] < yourNumber[z])
                    {
                        yourNumber[x] = yourNumber[z] + yourNumber[x];
                        yourNumber[z] = yourNumber[x] - yourNumber[z];
                        yourNumber[x] = yourNumber[x] - yourNumber[z];
                    }
                    x++;
                }
                x = 0;
            }
            Console.WriteLine($"The biggest number among both the element you've entered is {yourNumber[0]} ");


            foreach(var item in yourNumber)
            {
                Console.Write(item);
            }
           



        }
    }
}
