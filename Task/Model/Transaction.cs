using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class Transaction
    {
        public string AccountNumber { get; set; }
        public double TransactionAmount { get; set; }
        public string TypeOfTransaction { get; set; }
        public string TransactionAmountCurrency { get; set; }
        public string AccountCurrency { get; set; }
        public DateTime TransactionDateTime { get; set; }
    }
}
