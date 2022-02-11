using System;

namespace FCPA_CHAPTER_6_NO_12
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Write a program that converts a given number from decimal to binary
            //notation(numeral system).

            Console.Write("Enter your preferred number: ");
            int n = Int32.Parse(Console.ReadLine());

            string binaryNumber = Convert.ToString(n, 2);

            Console.WriteLine("your result is {0}", binaryNumber);

            Console.ReadLine();

































        }
    }
}
