using System;

namespace FCPA_CHAPTER_5_NO_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //   We are given 5 integer numbers. Write a program that finds those
            //subsets whose sum is 0.Examples:
            //-If we are given the numbers { 3, -2, 1, 1, 8}, the sum of - 2, 1 and 1
            //is 0.
            //- If we are given the numbers { 3, 1, -7, 35, 22}, there are no subsets
            //with sum 0.


            Console.Write("Enter your first number: ");
            sbyte firstNumber = sbyte.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            sbyte secondNumber = sbyte.Parse(Console.ReadLine());
            Console.Write("Enter your third number: ");
            sbyte thirdNumber = sbyte.Parse(Console.ReadLine());
            Console.Write("Enter your fourth number: ");
            sbyte fourthNumber = sbyte.Parse(Console.ReadLine());
            Console.Write("Enter your fifth number: ");
            sbyte fifthNumber = sbyte.Parse(Console.ReadLine());

            if(firstNumber + secondNumber == 0)
            {
                Console.WriteLine("{0} + {1} = 0", firstNumber, secondNumber);
            }
            if(firstNumber + thirdNumber == 0)
            {
                Console.WriteLine("{0} {1} = 0", firstNumber, thirdNumber);
            }
            if(firstNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} {1} = 0", firstNumber, fourthNumber);
            }
            if(firstNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} {1} = 0", firstNumber, fifthNumber);
            }
            if(secondNumber + thirdNumber == 0)
            {
                Console.WriteLine("{0} {1} = 0"  , secondNumber, thirdNumber);
            }
            if(secondNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} {1} = 0", secondNumber, fourthNumber);
            }
            if(secondNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} {1} = 0", secondNumber, fifthNumber);
            }
            if(thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} {1} = 0", thirdNumber, fourthNumber);
            }
            if(thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} {1} = 0", thirdNumber, fifthNumber);
            }
            if(fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} {1} = 0", fourthNumber, fifthNumber);
            }
            if(firstNumber + secondNumber + thirdNumber == 0)
            {
                Console.WriteLine("{0} {1} {2} = 0", firstNumber, secondNumber, thirdNumber);
            }
            if(firstNumber + secondNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} {1} {2} = 0", firstNumber, secondNumber, fourthNumber);
            }
            if(firstNumber + secondNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} {1} {2} = 0", firstNumber, secondNumber, fifthNumber);
            }
            if(firstNumber + thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} {1} {2} = 0", firstNumber, thirdNumber, fourthNumber);
            }
            if(firstNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} {1} {2} = 0", firstNumber, fourthNumber, firstNumber);
            }
            if(secondNumber + thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine("{0} {1} {2} = 0", secondNumber, thirdNumber, fourthNumber);
            }
            if(secondNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} {1} {2} = 0", secondNumber, fourthNumber, fifthNumber);
            }
            if(thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} {1} {2} = 0", thirdNumber, fourthNumber, fifthNumber);
            }
            if(fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine("{0} {1} = 0", fourthNumber, fifthNumber);
            }
            else
            {
                Console.WriteLine("there is know subset.");
            }


                     






































        }






                     


    }
}
