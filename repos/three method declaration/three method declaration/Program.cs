using System;

namespace three_method_declaration
{
    class Program
    {


        
        static void Main(string[] args)
        {

            int[] q = new int[5];
            for(int r = 0; r < 5; r++)
            {
                Console.WriteLine("Enter your preferred numbers:");
                q[r] = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine ($" the average is: {Mean(q)}");
        }



        public static int TotalSum(int [] myNumber)
        {

            int sum = 0;
            for(int p =0; p < myNumber.Length; p++)
            {
                sum += myNumber[p];  
            }
            return sum;


        }


        public static double Mean (int [] myNum)
        {
            int sum = TotalSum(myNum);
            double average = (double)sum / myNum.Length;

            return average;
        }
            















    }
}
