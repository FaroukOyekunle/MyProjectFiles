using System;

namespace NOVEMBER._9._ASSIGNMENT_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /* decimal balance = 25000.00m;
             Console.Write("enter the amount to withdraw: ");
             decimal amountwithdraw = Convert.ToDecimal(Console.ReadLine());
             int withdrawTme = DateTime.Now.Hour;
             decimal totalWithdraw = 0;
             decimal interest = 0;

             if(withdrawTme < 16)
             {
                 interest = 0.05m * amountwithdraw;
                 totalWithdraw = amountwithdraw + interest;
                 balance -= totalWithdraw;
             }
             else
             {
                 interest = 0.10m * amountwithdraw;
                 totalWithdraw = amountwithdraw + interest;
                 balance -= totalWithdraw;
             }
             if(balance > totalWithdraw)
             {
                 Console.WriteLine($"the withdraw is {balance}");
             }    */


                // WRITE A BOOLEAN EXPRESSION THAT CHECKS WHETHER A GIVEN INTEGER IS DIVISIBLE BY BOTH 5 AND 7, WITHOUT A REMAINDER. 
            int myNum = 35;
            Console.WriteLine((myNum % 5 == 0) && (myNum % 7 == 0));

        }
    }
}
