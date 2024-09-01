using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask.ViewModel;

namespace TestTask.View
{
    public partial class TransactionDetailForm : Form
    {
        private TransactionViewModel _transaction;
        public TransactionDetailForm(TransactionViewModel transaction)
        {
            InitializeComponent(); 
            _transaction = transaction;

            // Populate form controls with transaction data
            LoadTransactionDetails();
        }

        private void LoadTransactionDetails()
        {
            // Assuming you have TextBoxes named txtAccountNumber, txtTransactionAmount, etc.
            txtAccountNumber.Text = _transaction.AccountNumber;
            txtTransactionAmount.Text = _transaction.TransactionAmount.ToString();
            txtTypeOfTransaction.Text = _transaction.TypeOfTransaction;
            txtTransactionAmountCurrency.Text = _transaction.TransactionAmountCurrency;
            txtAccountCurrency.Text = _transaction.AccountCurrency;
            txtTransactionDateTime.Text = _transaction.TransactionDateTime.ToString("g"); // General date/time format
            txtTransactionAmountInAccountCurrency.Text = _transaction.TransactionAmountInAccountCurrency.ToString();
            txtBalanceAfterTheTransaction.Text = _transaction.BalanceAfterTheTransaction.ToString();
        }
    }
}
