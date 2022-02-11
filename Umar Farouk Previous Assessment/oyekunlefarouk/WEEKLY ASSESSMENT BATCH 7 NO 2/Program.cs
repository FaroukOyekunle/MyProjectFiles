    using System;

namespace WEEKLY_ASSESSMENT_BATCH_7_NO_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //   ⦁	(Game: lottery) Lottery, to generate a lottery of a three digit number.The program prompts the user to enter a three - digit number
            //   and determines whether the user wins according to the following rules: 1.If the user input matches the lottery number in the exact order,
            //   the award is $10,000. 2.If all the digits in the user input match all the digits in the lottery number, the award is $3,000.
            //   3.If one digit in the user input matches a digit in the lottery number, the award is $1,000.

            Random random = new Random();
            int count = 0;
            int myNumber = random.Next(100, 1000);
            Console.WriteLine(myNumber);
            Console.Write(" Enter your preferred number: ");
            int yourNumber = int.Parse(Console.ReadLine());

            if(yourNumber == myNumber)
            {
                Console.WriteLine(" Congratulations! you have been awarded with the total sum of $10,000 ");
            }

            string k = myNumber.ToString();
            string a = yourNumber.ToString();

            for (int b = 0; b < k.Length; b++)
            {
                for(int i = 0; i < a.Length; i++)
                {
                    if(k[b] == a[i])
                    {
                        count++;
                    }
                }
            }

            if(count == 3)
            {
                Console.WriteLine(" congratulations! you have been awarded with the total sum of $3,000.");
            }

            else if( count == 1)
            {
                Console.Write(" Congratulations! you have been awarded with the sum of $1,000.");
            }

            else
            {
                Console.WriteLine(" your input is invalid.");
            }









































            /*   for (int i = 0; i < 2; i++);
               {
                   for (int k = 0; k < 2; k++) ;
                   {
                       Console.Write([i,j] + )
                   }
               }  */


            /* int[,] arr = new int[2, 2];
              arr[0, 0] = 3;
             arr[1, 0] = 4;
             arr[1, 0] = 2;
             arr[1, 1] = 1;

             for (int k = 0; k < 2;k++)
             {
                 for (int a = 0; a < 2; a++)
                 {
                     Console.Write(arr[k, a] + " ");
                 }
                 Console.WriteLine();
             }  */

































        }
    }
}
