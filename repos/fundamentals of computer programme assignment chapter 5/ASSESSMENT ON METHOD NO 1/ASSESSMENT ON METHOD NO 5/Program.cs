using System;

namespace ASSESSMENT_ON_METHOD_NO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that checks whether an element, from a certain position
            //in an array is greater than its two neighbors.Test whether the
            //method works correctly.

            int[] yourNumber = new int[3];
            int numberEntered = 0;

            for(int k = 0; k < 3; k++)
            {
                Console.Write("Enter a preferred number: ");
                numberEntered = int.Parse(Console.ReadLine());

                yourNumber[k] = numberEntered;
            }
            Console.WriteLine($"{CheckAnElement(numberEntered, yourNumber)}");

        }

        public static bool CheckAnElement(int yourNumber, int [] elementsInArray)
        {
            bool biggestNumber = true;
            if(elementsInArray[0] > elementsInArray[1] && elementsInArray[2] < elementsInArray[0])
            {
                Console.WriteLine($"{elementsInArray[0]} is the greater integers among all.");
            }
            else if(elementsInArray[1] > elementsInArray[0] && elementsInArray[2] < elementsInArray[1])
            {
                Console.WriteLine($"{elementsInArray[1]} is the greater integer among all.");
            }
            else if(elementsInArray[2] > elementsInArray[0] && elementsInArray[1] < elementsInArray[2])
            {
                Console.WriteLine($"{elementsInArray[2]} is the greater integer among all.");
            }
            return biggestNumber;
        }
    }
}
