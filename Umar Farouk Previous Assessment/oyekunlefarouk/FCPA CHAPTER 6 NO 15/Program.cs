using System;

namespace FCPA_CHAPTER_6_NO_15
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program that converts a given number from hexadecimal to
            //decimal notation.


            Console.Write("Enter your preferred number: ");
           int number = Int32.Parse(Console.ReadLine());

            string todecimal = Convert.ToString(Convert.ToInt32(number,16), 10);
            Console.WriteLine("your conversion from hexadecimal to decimal notation is: {0} ", todecimal);


            Console.ReadLine();
    
        }
    }
}
