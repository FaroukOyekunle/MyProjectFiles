using System;

namespace ASSESSMENT_ON_METHOD_NO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a method that returns the position of the first occurrence of an
            //element from an array, such that it is greater than its two neighbors
            //simultaneously.Otherwise the result must be - 1.

            Console.WriteLine("Enter your preferred array length: ");
            int SizeOfArray = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int[] numbers = new int[SizeOfArray];

            for(int i = 0; i < SizeOfArray; i++)
            {
                Console.WriteLine("Enter your preferred element: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the digit you which to check if its  truly greater than its neighbour:  ");
            int output = int.Parse(Console.ReadLine());

            if(CheckInput(numbers,output) == 1)
            {
                CheckIndex = (numbers, output);
            }
            else
            {
                Console.WriteLine("invalid digit entered.");
            }
        }
        static void CheckIndex(int [] numbers, int arrayElement) 
        {
            int x = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(arrayElement == numbers[i])
                {
                    x = i;
                    break;
                }
            }

            if(CheckWetherDigitIsGreaterThanNeighbour(numbers, x) == true)
            {
                Console.WriteLine($"The first occurrence of the number you entered" +
                    $" and also greater than its neighbour is at index {x}");
            }
            else if(CheckWetherDigitIsGreaterThanNeighbour(numbers, x) == false)
            {
                Console.WriteLine($"The first occurrence of the number you entered" +
                    $" is not greater than its two neighbour.");
            }
        }

        static bool CheckWetherDigitIsGreaterThanNeighbour(int [] numbers , int element)
        {
            bool checker = false;
            int left = element - 1;
            int right = element + 1;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[element] == numbers[0])
                {
                    if(numbers[element] > numbers[right])
                    {
                        checker = true;
                    }
                }

                else if(numbers[element] == numbers[numbers.Length - 1])
                {
                    if(numbers[element] > numbers[left])
                    {
                        checker = true;
                    }
                }

                else if(numbers[element] > numbers[right] && numbers[element] > numbers[left])
                {
                    checker = true;
                }
            }
            return checker;
        }

        static int CheckInput(int [] numbers, int element)
        {
            int i = 0;
            
            foreach(var item in numbers)
            {
                if(item == element)
                {
                    i = 1;
                    break;
                }
            }
            return i;
        }
    }
}
