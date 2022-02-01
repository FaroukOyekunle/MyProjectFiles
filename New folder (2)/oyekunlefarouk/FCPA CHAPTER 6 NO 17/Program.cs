using System;

namespace FCPA_CHAPTER_6_NO_17
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that given two numbers finds their greatest common
            //divisor(GCD) and their least common multiple(LCM).You may use
            //the formula LCM(a, b) = | a * b | / GCD(a, b).

            Console.Write("Enter your preferred number: ");
            int numberA = Int32.Parse(Console.ReadLine());

            Console.Write("Enter your second prteferred number: ");
            int numberB = Int32.Parse(Console.ReadLine());

            while (numberA != 0 && numberB != 0)

                if (numberA > numberB) numberA %= numberB;


                else numberB %= numberA;
            
               
            if(numberA == 0)
            {
                Console.WriteLine(numberB);
            }
            else
            {
                Console.WriteLine(numberA);
            }

            Console.ReadLine();




























        }
    }
}
