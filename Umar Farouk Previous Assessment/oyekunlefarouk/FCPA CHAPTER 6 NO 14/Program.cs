using System;

namespace FCPA_CHAPTER_6_NO_14
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Write a program that converts a given number from decimal to
            //hexadecimal notation.

            Console.Write("Enter your preferred decimal number: ");
            int number = Int32.Parse(Console.ReadLine());

            string ToDecimal = Convert.ToString(number, 16).ToUpper();
            Console.WriteLine("your conversion from decimal to hexadecimal is:  {0}", ToDecimal);

            Console.ReadLine();
































        }
    }
}
