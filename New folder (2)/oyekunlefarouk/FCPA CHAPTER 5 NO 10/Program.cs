using System;

namespace FCPA_CHAPTER_5_NO_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that applies bonus points to given scores in the range
            //[1…9] by the following rules:
            //-If the score is between 1 and 3, the program multiplies it by 10.
            //- If the score is between 4 and 6, the program multiplies it by 100.
            //- If the score is between 7 and 9, the program multiplies it by 1000.
            //- If the score is 0 or more than 9, the program prints an error
            //message.


            int bonusPoints;
            Console.Write("Enter your bonus points between 1 and 9: ");
            bonusPoints = int.Parse(Console.ReadLine());
            if (bonusPoints >= 1 && bonusPoints <= 3)
            {
                Console.WriteLine("the bonus points multiplied by 10: {0}", bonusPoints * 10);
            }
            else if (bonusPoints >= 4 && bonusPoints <= 6)
            {
                Console.WriteLine("the bonus points multiplied by 100: {0}", bonusPoints * 100);
            }
            else if (bonusPoints >= 7 && bonusPoints <= 9)
            {
                Console.WriteLine("the bonus points multiplied by 1000: {0}", bonusPoints * 1000);
            }
            else
            {
                Console.WriteLine("the input you've entered is invalid.");
            }

            Console.ReadLine();































        }
    }
}
