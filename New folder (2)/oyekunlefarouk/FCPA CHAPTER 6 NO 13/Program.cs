using System;

namespace FCPA_CHAPTER_6_NO_13
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Write a program that converts a given number from binary to decimal
            //notation.

            Console.Write("Enter your preferred number between 0 and 1: ");
            int number = Int32.Parse(Console.ReadLine());

            int ToDecimal = Convert.ToInt32(number.ToString(),2); 

            Console.WriteLine("result is equal to {0}", ToDecimal);

































        }
    }
}
