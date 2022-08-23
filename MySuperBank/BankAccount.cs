using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount
    {
        private List<Transaction> allTransactions = new List<Transaction>();

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private static int AccountNumberSeed = 1234567890;

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Starting Balance");
            Number = AccountNumberSeed.ToString();
            AccountNumberSeed++;
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("The amount must be positive.");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient Funds to Withdraw this amount.");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);

        }
        public string getAccountHistory()
        {
            var report = new StringBuilder();

            //HEADER
            report.AppendLine("Date \t Amount \t Note");
            foreach (var item in allTransactions)
            {
                //ROWS
                report.AppendLine($"{item.Date.ToShortDateString()}\t {item.Amount} \t {item.Notes}");
            }
            return report.ToString();
        }
    }
}
