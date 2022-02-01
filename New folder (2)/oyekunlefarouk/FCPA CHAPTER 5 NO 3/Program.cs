using System;

namespace FCPA_CHAPTER_5_NO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the biggest of three integers, using nested
            //if statements.
            Console.Write("enter your first integer:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("enter your second integer: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("enter your third integer: ");
            int num3 = int.Parse(Console.ReadLine());


             if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write($"{num1} is the greatest among three. ");
                }
                else
                {
                    Console.Write($"{num3} is the greatest among three. ");
                }
            }
             else if (num2 > num3)
                 Console.Write($"{num2} is the greatest among three. ");
              else
              Console.Write($"{num3} is the greatest among three. ");
             Console.ReadKey();   
        }

    }
}
