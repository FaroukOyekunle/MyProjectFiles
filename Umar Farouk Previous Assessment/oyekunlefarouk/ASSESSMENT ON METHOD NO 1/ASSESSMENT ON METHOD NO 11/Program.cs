using System;

namespace ASSESSMENT_ON_METHOD_NO_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that solves the following tasks:
            //-Put the digits from an integer number into a reversed order.
            //-Calculate the average of given sequence of numbers.
            //- Solve the linear equation a *x + b = 0.
            //Create appropriate methods for each of the above tasks.
            //Make the program show a text menu to the user.By choosing an option
            //of that menu, the user will be able to choose which task to be invoked
            //  Perform validation of the input data:
            //-The integer number must be a positive in the range[1…50, 000, 000].
            //-The sequence of numbers cannot be empty.
            //-The coefficient a must be non - zero.



        }
        static void ReverseOfAdigit(int number)
        {

            int division = 0;
            int modulo = 0;
            Console.Write("the final rewsult of your calculation is: ");
            for (; ; )
            {
                division = number / 10;
                modulo = number % 10;

                Console.Write($"{modulo}");
                number = division;
                if(division == 0)
                {
                    break;
                }
            }

        }

    }
}
