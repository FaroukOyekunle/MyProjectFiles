using System;

namespace FCPA_CHAPTER_7_NO_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program, which reads two arrays from the console and checks
            //whether they are equal(two arrays are equal when they are of equal
            //length and all of their elements, which have the same index, are equal).

            bool equalArray = true;

            Console.Write("Enter the length of the first array: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr1 = new int[length];
            for(int p = 0; p < arr1.Length; p++)
            {
                Console.Write("Enter the elements {0: ", p);
                arr1[p] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n Enter the length of your secong preferred array: ");

            if (length != Int32.Parse(Console.ReadLine()))
            {
                Console.WriteLine("\n the arrays has a different lengths:  ");
            }
            else
            {
                int[] arr2 = new int[length];
                
                for (int q = 0; q < arr2.Length; q++)
                {
                    Console.Write("try to enter the element{0}: ", q);
                    arr2[q] = Int32.Parse(Console.ReadLine());
                }
                for(int r = 0; r < arr1.Length; r++ )
                {
                    if(arr1[r] != arr2[r])
                    {
                        Console.WriteLine("\n different been made in the array. ");
                        equalArray = false;
                        break;
                    }
                }
                if (equalArray)
                {
                    Console.WriteLine("\n the total arrays involve are all the same. ");
                }
            }


































        }
    }
}
