using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; } 
        public string Notes { get; }

        public Transaction(decimal Amount, DateTime Date, string Note)
        {
            this.Amount = Amount;
            this.Date = Date;
            this.Notes = Note;
        }
    }
}
