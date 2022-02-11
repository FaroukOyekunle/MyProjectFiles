using System;

namespace FCPA_CHAPTER_6_NO_16
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that by a given integer N prints the numbers from 1 to N 
            //in random order.

            Random random = new Random();
            int number, randomNumber;
            Console.Write("Enter your preferred number: ");
            int number1 = Int32.Parse(Console.ReadLine());

            int [] arr = new int[number1];

            for(int p = 0; p < arr.Length; p++)
            {
                arr[p] = p;
            }
            foreach(int p in arr)
            {
                randomNumber = random.Next(0, number1);
                number = arr[p];
                arr[p] = arr[randomNumber];
                arr[randomNumber] = number;

            }
            foreach(int p in arr)
            {
                Console.WriteLine(arr[p]);
            }

            Console.ReadLine();
























        }
    }
}
