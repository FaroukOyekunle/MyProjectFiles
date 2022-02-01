using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
           int []arr = {1, 1, 2, 2, 2, 3 };
           int k = arr.Length;

           k = DuplicateValue(arr, k);

           for(int i = 0; i < k; i++)
           {
               Console.WriteLine(arr[i] );
           }
        }
        static int DuplicateValue(int[] arr, int k)
        {
            if(k == 0 && k == 1)
            {
                return k;
            }
            int[] nums = new int [k];
            int f = 0;

            for(int i = 0; i < k - 1; i++)
            {
                if(arr[i] != arr[i + 1])
                {
                    nums[f++] = arr[i];
                     nums[f++] = arr[k - 1];
                }

            }
            return f;
        }
    }
}
