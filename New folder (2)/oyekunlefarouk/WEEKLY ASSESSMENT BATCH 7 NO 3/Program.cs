using System;

namespace WEEKLY_ASSESSMENT_BATCH_7_NO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Random character) Write a program that displays a random uppercase letter
            //using the Math.random() method


            string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Random random =  new Random();
            int letters = random.Next(0, 26);

            Console.WriteLine(letters);

            for(int a = 0; a <= 26; a++)
            {
                if(letters == 1)
                {
                    Console.WriteLine($"{alphabet[a]}");
                }
            }
        }
    }
}
