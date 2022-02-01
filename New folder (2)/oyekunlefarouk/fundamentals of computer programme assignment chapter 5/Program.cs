using System;

namespace fundamentals_of_computer_programme_assignment_chapter_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Write an if-statement that takes two integer variables and exchanges
            //their values if the first one is greater than the second one.
            Console.Write("enter your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("enter your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int thirdNumber = 0;

            if(firstNumber > secondNumber)
            {
                thirdNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
            Console.WriteLine($" the greater integer among the exchange sets is:  {secondNumber}");    
        }
    }
}

