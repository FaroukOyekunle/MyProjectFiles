using System;

namespace FCPA_CHAPTER_5_NO_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the greatest of given 5 numbers.
            Console.Write("enter your first number.");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("enter your second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("enter your third number:");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.Write("enter your fourth number:");
            int fourthNumber = int.Parse(Console.ReadLine());
            Console.Write("enter your fifth number:");
            int fifthNumber = int.Parse(Console.ReadLine());

            
                if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
                {
                  Console.WriteLine($" {firstNumber} is the greatest among all given integers.");
                }
                 if(secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
                 {
                   Console.WriteLine($"{secondNumber} is the greatest among all given integers. ");
                 }
                
                if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
                {
                    Console.WriteLine($"{thirdNumber} is the greatest among all given integers.");
                }     
                if(fourthNumber > firstNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
                {
                    Console.WriteLine($"{fourthNumber} is the greatest among all given integers.");
                }
                if(fifthNumber > firstNumber && fifthNumber > secondNumber && fifthNumber > thirdNumber && fifthNumber > fourthNumber)
                {
                    Console.WriteLine($"{fifthNumber} is the greatest among all given integers.");
                }
               
                















        }
        
    }
}
