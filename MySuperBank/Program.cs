using System;
using MySuperBank;

namespace MyBankAccount
{

    class Program
    {
        static void Main(string[] args)
        {

            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            /* Test Withdrawals
            //withdrawal 1
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            //withdrawal 2
            account.MakeWithdrawal(50, DateTime.Now, "Flight Simulator for PC");
            Console.WriteLine(account.Balance);
            */

            //Show Account History
            Console.WriteLine(account.getAccountHistory());


            ////test of withdrawal balance exceeding exception
            //try
            //{
            //    account.MakeWithdrawal(75000, DateTime.Now, "Attempt to Overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught: the amount attempted to withdraw is higher than your current balance.");
            //    Console.WriteLine(e.ToString);
            //}
            ////test om det er positive number withdrawal
            //try
            //{
            //    var invalidAccount = new BankAccount("Invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with a negative Balance.");
            //    Console.WriteLine(e.ToString);
            //}

        }
    }
}