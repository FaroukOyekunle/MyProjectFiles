using System;

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string String2 = "adamkaabiibadam";
            Console.Write("\n The Equivalent Length Is  " + LongestSubstring(String2));
        }

        //Method to Print a susbstring string1[firstNumber  and secondNumber]....
        static void PrintSubString(string string1, int firstNumber, int secondNumber)
        {
            //Method to Print a susbstring string1[firstNumber  and secondNumber]....
            for(int i = firstNumber; i<= secondNumber; i++)
            Console.Write(string1[i]);

        }

        //This Method Print The Longest Palindromic Substring ....
        //And The Method Also Return The Length ...
        //Of The Longest Palindromic substring...
        static int LongestSubstring(string String2)
        {
        //This Method Print The Longest Palindromic Substring ....
        //And The Method Also Return The Length ...
        //Of The Longest Palindromic substring...

        //variable Declaration to get the length of the input string...
            int k = String2.Length;

            //getting the substring of length that are palindrome
            int MaximumLength = 1;
            int InitialCount = 0;

         //outer loop to pick all substring from the start to the end and vice versa 
            for(int x = 0; x <String2.Length; x++)
            {
                for(int y = x; y <String2.Length; y++)
                {
                    int Input = 1;

            //inner loop is been used to check wether the substring picked are paliondrome...
                    for(int z = 0; z < (y - x + 1) / 2; z++)
                    if(String2[x + z] != String2[y - z])
                    Input = 0;

                //if statement to check wether the input string are palindrome..
                    if(Input != 0 && (y - x + 1) > MaximumLength)
                    {
                        InitialCount = x;
                        MaximumLength = y - x + 1;
                    }
                }
            }
            Console.Write("The Longest Output Substring is: ");
            PrintSubString(String2, InitialCount, InitialCount + MaximumLength - 1);

            //returning the Longest substring picked....
            return MaximumLength;
        }
    }
}
