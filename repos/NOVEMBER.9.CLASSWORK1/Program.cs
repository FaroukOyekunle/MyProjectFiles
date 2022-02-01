using System;

namespace NOVEMBER._9.CLASSWORK1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrEven1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arrEven2 = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };

            int arr1 = arrEven1[0];
            int arr2 = arrEven1.Length / 2;            
            int evenLength = arrEven1[arrEven1.Length - 1];
            int X = arrEven1[arr2];

            Console.WriteLine(arr1);
            Console.WriteLine(evenLength);
            Console.WriteLine(X);

            int arr3 = arrEven2[0];
            int arr4 = arrEven2.Length / 2;
            int oddLength = arrEven2[arrEven2.Length - 1];
            int Y = arrEven2[arr4];
                                                                                                                                                                                                                                                                                                                             
            Console.WriteLine();
        }
    }
}
