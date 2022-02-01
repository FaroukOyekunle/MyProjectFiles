using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCLASSWORK
{
    class Account
    {
        string AccountName;

        string AccountNumber;

        double AccountBalance;

        DateTime DateOfCreation;

        List<string> history = new List<string>();

        public Account(string accountName, string accountNumber)
        {
            AccountName = accountName;
            AccountNumber = accountNumber;
            AccountBalance = 10000;
            DateOfCreation = DateTime.Now;

           


        }

        public void Deposit(double amountToDeposit)
        {
            AccountBalance = AccountBalance + amountToDeposit;
            string h = $"Dear user, your account has been credited with ${amountToDeposit} as at {DateTime.UtcNow}, and your new account balance is ${AccountBalance}";
            history.Add(h);
            Console.WriteLine(h);
            
        }

        public void Withdraw(double amountToWithdraw)
        {
            if (amountToWithdraw < AccountBalance)
            {
                AccountBalance = AccountBalance - amountToWithdraw;
                string h = $"Dear user, your account has been debited with ${amountToWithdraw}, as at {DateTime.Now}, and your new account balance is ${AccountBalance}";
                history.Add(h);
                Console.WriteLine(h);
            }
            else
            {
                Console.WriteLine("Insufficient balance! ");
            }
        }

        public void CheckAccountBalance()
        {
            Console.WriteLine($"Dear user, your current account balance as at ,{DateTime.Now}, is now: ${AccountBalance}");
        }

        public void History()
        {
            foreach(var item in history)
            {
                Console.WriteLine(item);
            }
        }

    }
}
