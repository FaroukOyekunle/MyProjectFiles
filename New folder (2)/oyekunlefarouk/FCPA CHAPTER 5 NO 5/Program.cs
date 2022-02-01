using System;

namespace FCPA_CHAPTER_5_NO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Write a program that asks for a digit (0 - 9), and depending on the input,
            //   shows the digit as a word(in English).Use a switch statement.
            Console.Write("enter your number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            switch(firstNumber)
            {
                case 0:
                Console.WriteLine("the number you entered is translated to zero.");
                    break;
                case 1:
                    Console.WriteLine("the number you entered is translated to one.");
                    break;
                case 2:
                    Console.WriteLine("the number you entered is translated to two.");
                    break;
                case 3:
                    Console.WriteLine("the number you entered is translated to three.");
                    break;
                case 4:
                    Console.WriteLine("the number you entered is translated to four.");
                    break;
                case 5:
                    Console.WriteLine("the number you entered is translated to five. ");
                    break;
                case 6:
                    Console.WriteLine("the number you entered  is translated to six.");
                    break;
                case 7:
                    Console.WriteLine("the number you entered is translated to seven.");
                    break;
                case 8:
                    Console.WriteLine("the number is entered is translated to eight.");
                    break;
                case 9:
                    Console.WriteLine("the number you entered is translated to nine. ");
                    break;
                default:
                    Console.WriteLine(" the digit you've entered is invalid.");
                        break;
            }
        }
    }
}
