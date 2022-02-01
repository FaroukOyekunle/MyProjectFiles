using System;

namespace ASSESSMENT_ON_METHOD_NO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that returns the English name of the last digit of a
            //given number. Example: for 512 prints "two"; for 1024  "four".


            Console.Write("Enter a preferred number of your choice: ");
            string number = Console.ReadLine();
            getYourName(number);

        }
        static void getYourName(string yourNumber)
        {
            switch (yourNumber[yourNumber.Length - 1])
            {
                case '1':
                    Console.WriteLine("one");
                    break;
                case '2':
                    Console.WriteLine("two");
                    break;
                case '3':
                    Console.WriteLine("three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break;
                case '5':
                    Console.WriteLine("five");
                    break;
                case '6':
                    Console.WriteLine("six");
                    break;
                case '7':
                    Console.WriteLine("seven");
                    break;
                case '8':
                    Console.WriteLine("eight");
                    break;
                case '9':
                    Console.WriteLine("nine");
                    break;
                case '0':
                    Console.WriteLine("zero");
                    break;
            }
        }
    }
}
