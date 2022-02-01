using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing all Even Number multiplied by Two And Division all Odd Number By Two.....
           /* int[] nums = { 50, 52, 54, 56, 58, 60, 62, 64, 66, 68 };

            for (int i = 0, x = 1; i < 9 && x < 10; i += 2, x++)
            {
                Console.WriteLine($"{nums[i] * 2} \t {nums[x] / 2}");
            }*/

            //Reversing all the element in an a array...

            Console.Write("Enter your specified array you which to reversed");
            int lengthOfArray = int.Parse(Console.ReadLine());
            int[] numbers = new int[lengthOfArray];

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter your number{i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] reversedArray = new int[numbers.Length];

            for(int i = 0; i < numbers.Length; i++)
            {
                reversedArray[numbers.Length - 1 - i] = numbers[i];
            }

            Console.Write("your new reversed array elements are: ");
            foreach(int num in numbers)
            {
                
            }



            //MiltiDimensional Array Declaration...
            int[,] array = {
                {10, 20, 30, 40 },
                {11, 22, 33, 44 },
                {12, 24, 36, 48 } };
            Console.WriteLine(array[2, 3]);

            //Getting the row in an array....
            Console.WriteLine(array.GetLength(0));
            //Getting the column in an array....
            Console.WriteLine(array.GetLength(1));



            for(int row = 0; row < array.GetLength(0); row++)
            {
                for(int column = 0; row < array.GetLength(1); column++)
                {
                    Console.WriteLine($"{array[row, column]}");
                }
            }
        }
    }
}
