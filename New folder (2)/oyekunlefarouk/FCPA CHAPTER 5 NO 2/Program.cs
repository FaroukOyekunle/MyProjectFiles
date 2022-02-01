using System;

namespace FCPA_CHAPTER_5_NO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that shows the sign(+or -) of the product of three real
            //numbers, without calculating it.Use a sequence of if operators
               Console.Write("enter your first number: ");
               int p = int.Parse(Console.ReadLine());
              Console.Write("enter your second number: ");
              int q = int.Parse(Console.ReadLine());
            Console.Write("enter your third number: ");
            int r = int.Parse(Console.ReadLine());

            if (p < 0 && q < 0 && r < 0) 
            {
                Console.WriteLine("-");
            }
            else if(p >= 0 && q >= 0 && r >= 0)
            {
                Console.WriteLine("+");
            }
            else if(p < 0 && q < 0 && r >= 0)
            {
                Console.WriteLine("+");
            }
            else if(p < 0 && q >= 0 && r < 0)
            {
                Console.WriteLine("+");
            }
            else if(p >= 0 && q < 0 && r < 0)
            {
                Console.WriteLine("+");
            }
            else if(p < 0 && q >= 0 && r >= 0)
            {
                Console.WriteLine("-");
            }
            else if(p >= 0 && q < 0 && r >= 0)
            {
                Console.WriteLine("-");
            }
            else if(p >= 0 && q >= 0 && r < 0)
            {
                Console.WriteLine("-");
            }
        }
    }
}
