using System;

namespace MaxOccourence
{
    class Program
    {
        static void Main(string[] args)
        {


            var test = new int[]{ 1, 1, 1, 2, 2, 2, 6,6,6,6,6, 3, 3, 2,2 };

            int current = 0;
            int currentCount = 0;
            int max = 0;
            int maxCount = 0;

            foreach(var num in test)
            {
                if(num != current)
                {

                    if(maxCount < currentCount)
                    {
                        max = current;
                        maxCount = currentCount;
                    }
                  
                    current = num;
                    currentCount=1;
                }
                else
                {
                    currentCount++;
                }


            }
            

            for(int i = 0; i < maxCount; i++)
            {
                Console.Write(max + ", ");
            }
        }
    }
}
