using System;

namespace FCPA_CHAPTER_6_NO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that prints on the console the numbers from 1 to N. 
            //The number N should be read from the standard input.


            Console.Write("Enter your first number: ");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }



































        }
    }
}
