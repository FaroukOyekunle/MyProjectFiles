using System;

namespace FCPA_CHAPTER_7_NO_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program, which creates an array of 20 elements of type
            //integer and initializes each of the elements with a value equals to the
            //index of the element multiplied by 5.Print the elements to the console

            int[] arr = new int[20];
            for (int p = 0; p < arr.Length; p++)
            {
                arr[p] = p * 5;

                Console.WriteLine(arr[p]);

            }

            Console.ReadLine();



































        }
    }
}
