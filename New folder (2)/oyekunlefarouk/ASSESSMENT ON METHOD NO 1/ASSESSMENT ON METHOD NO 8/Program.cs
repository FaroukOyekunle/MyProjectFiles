using System;

namespace ASSESSMENT_ON_METHOD_NO_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Write a method that calculates the sum of two very long positive
            //integer numbers. The numbers are represented as array digits and
            //the last digit(the ones) is stored in the array at index 0.Make the
            //method work for all numbers with length up to 10, 000 digits.

            Console.WriteLine("Enter your preferred first number; ");
            string firstNumber1 = Console.ReadLine();
            Console.WriteLine("Enter your preferred second number:  ");
            string secondNumber2 = Console.ReadLine();

            if(firstNumber1.Length >= secondNumber2.Length)
            {
                int[] firstNumber = new int[firstNumber1.Length];
                int[] secondNumber = new int[secondNumber2.Length];



                for(int i = 0; i < firstNumber1.Length; i++)
                {
                    char x = firstNumber1[firstNumber1.Length - (1 -i)];
                    firstNumber[i] = (int)x;
                }


                for(int i = 0; i < i++)
                {

                }
                      
            }
        }
    }
}
