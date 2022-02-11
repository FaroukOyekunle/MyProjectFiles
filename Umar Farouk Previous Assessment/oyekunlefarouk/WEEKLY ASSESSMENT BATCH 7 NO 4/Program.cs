using System;

namespace WEEKLY_ASSESSMENT_BATCH_7_NO_4
{
    class Program
    {
        static void Main(string[] args)
        {
           // Given two sorted arrays, merge and return and a sorted array
            var myNumber = new int[] { 3, 2, 3, 4, 2, 2, 4 };
            int increement = 0;
            int increementCount = 0;
            int maximum = 0;
            int maximumCount = 0;

            foreach(var number in myNumber)
            {
                if(number != increement)
                {
                    if(maximumCount < increementCount)
                    {
                        maximum = increement;
                        maximumCount = increementCount;
                    }
                    increement = number;
                }
            }

        }
    }
}
