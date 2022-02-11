using System;

namespace FCPA_CHAPTER_5_NO_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that, depending on the user’s choice, inputs int, double
            //or string variable. If the variable is int or double, the program
            //increases it by 1.If the variable is a string, the program appends "*" at
            //the end.Print the result at the console. Use switch statement.



            Console.WriteLine("Input 1 for double , 0 for int , 2 for string.");
            byte answer = byte.Parse(Console.ReadLine());

            switch(answer)
            {
                case 0:
                    Console.WriteLine("Enter a number: ");
                    int number = int.Parse(Console.ReadLine());
                    ++number;
                    Console.WriteLine($"the result of the number you entererd increased by 1 = {number}");
                    break;
                case 1:
                    Console.WriteLine("Enter  another number: ");
                    double number1 = int.Parse(Console.ReadLine());
                    ++number1;
                    Console.WriteLine($"the result of the number you entered increased by 1 = {number1}");
                    break;
                case 2:
                    Console.WriteLine("Enter a text: ");
                    string text = Console.ReadLine();
                    Console.WriteLine($"the text you entered is appended with \" * \" = {text} ");
                    break;
                default:
                    Console.WriteLine("your input is invalid.");
                    break;

            }
        }
    }
}
