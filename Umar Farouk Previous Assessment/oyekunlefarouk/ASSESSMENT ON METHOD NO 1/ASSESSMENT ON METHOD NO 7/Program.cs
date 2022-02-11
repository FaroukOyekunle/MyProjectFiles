using System;

namespace ASSESSMENT_ON_METHOD_NO_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a method that prints the digits of a given decimal number in a
            // reversed order.For example 256, must be printed as 652.

            ReverseOrderOfAdigit();

        }
        public static void ReverseOrderOfAdigit()
        {
            Console.Write("Enter a preferred ");
            int yourNumber = int.Parse(Console.ReadLine());

            int reverseValueOfADigit = 0;

            int moduloOfTheValue = 0;
            for(;;)
            {
                int divisionOfTheValue = yourNumber / 10;
                moduloOfTheValue = yourNumber % 10;
                yourNumber = divisionOfTheValue;
                reverseValueOfADigit = moduloOfTheValue;

                Console.Write($"{reverseValueOfADigit}");
                if(divisionOfTheValue == 0)
                {
                    break;
                }
                
            }

        }
    }
}
