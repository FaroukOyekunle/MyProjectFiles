using System;

namespace ASSESSMENT_ON_METHOD_NO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method GetMax() with two integer(int) parameters, that
            //returns maximal of the two numbers.Write a program that reads three
            //numbers from the console and prints the biggest of them. Use the
            //GetMax() method you just created. Write a test program that validates
            //that the methods works correctly


            Console.Write("Enter your first integer: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your second integer: ");
            int secondNumber = int.Parse(Console.ReadLine());

           
            int maxValue = GetMax(firstNumber, secondNumber);
            Console.Write("Enter your preferred third integer: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The biggest number  among the above integer using the getmax method is:  { GetMax(maxValue, thirdNumber)}");
        }

        public static int GetMax (int firstNumber, int secondNumber)
        {
            int maximumValue = 0;
            if(firstNumber > maximumValue)
            {
                maximumValue = firstNumber;
            }
            if(secondNumber > maximumValue)
            {
                maximumValue = secondNumber;
            }
            return maximumValue;
        }
            
        
    }
}
