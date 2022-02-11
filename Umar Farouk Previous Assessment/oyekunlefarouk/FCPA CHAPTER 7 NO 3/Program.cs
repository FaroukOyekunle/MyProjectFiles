using System;

namespace FCPA_CHAPTER_7_NO_3
{
    class Program
    {
        static void Main(string[] args)
        {


            // Write a program, which compares two arrays of type char
            //lexicographically(character by character) and checks, which one is first
            //in the lexicographical order.


            bool isArrayEequal = true;
            char[] firstArray = new char[5] { 'a', 's', 'a', 'k', 'e' };
            char[] secondArray = new char[5] { 'a', 's', 'a', 'k', 'e' };

            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("the second array is lexigraphical: ");
            }
            else if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("the first array is lexographical: ");     
            }
            else
            {
                for (int p = 0; p < firstArray.Length; p++)
                {
                    if (firstArray[p] < secondArray[p])
                    {
                        Console.WriteLine("the first array is also lexographical: ");
                        isArrayEequal = false;
                        break;
                    }
                    if(firstArray[p] > secondArray[p])
                    {
                        Console.WriteLine("the second array is lexxographical: ");
                        isArrayEequal = false;
                        break;
                    }
                }
                if(isArrayEequal)
                {
                    Console.WriteLine("the both array are lexographically equal to each other.");
                }
            }


            Console.ReadLine();






































        }
    }
}
