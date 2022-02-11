using System;

namespace FCPA_CHAPTER_6_NO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci numbers start from 0 and 1, each additional is obtained as
            //the sum of the previous two.You can find the first n Fibonacci
            //numbers with a for-loop from 1 to n, and at each iteration calculate the
            //next number by using the previous two(which you will keep in two
            //additional variables)



            int firstNumber = 0;
            int secondNumber = 1;
            int thirdNumber = 0;

            Console.Write("enter your nth term number: ");
            int yourNumber = Int32.Parse(Console.ReadLine());

            Console.Write("0, 1,");

            for(int p = 2; p < yourNumber; p++)
            {
                thirdNumber = firstNumber + thirdNumber;
                Console.Write("{0},", thirdNumber);
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }

            Console.ReadLine();



















        }
    }
}
