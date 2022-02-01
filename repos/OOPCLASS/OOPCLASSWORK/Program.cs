using System;

namespace OOPCLASSWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstUser = new Account("1238512831", "owoade fuad ayinde");
            var secondUser = new Account("3049774581", "trent alexander arnold");
          

            bool rerun = true;
            while(rerun)
            {
                Console.WriteLine("Enter 1 to perform deposit\nEnter 2 to withdraw\nEnter 3 to Check balance\nEnter 4 to print history\nEnter 5 to exit");
                int input = int.Parse(Console.ReadLine());

                if(input == 1)
                {
                    Console.WriteLine("Enter amount to deposit");
                    double amountToDeposit = double.Parse(Console.ReadLine());
                    firstUser.Deposit(amountToDeposit);
                    
                }

                else if(input == 2)
                {
                    Console.WriteLine("Enter amount to ");
                    double amountToWithdraw = double.Parse(Console.ReadLine());
                    firstUser.Withdraw(amountToWithdraw);
                }

                else if(input == 3)
                {
                    firstUser.CheckAccountBalance();
                }

                else if(input == 4)
                {
                    firstUser.History();
                }

                else
                {
                    rerun = false;
                }
            }
        } 
    }    

}
 