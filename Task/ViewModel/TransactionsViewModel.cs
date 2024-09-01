using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestTask.ViewModel
{ 
    public class TransactionViewModel : INotifyPropertyChanged
    {
        private string _accountNumber;
        private double _transactionAmount;
        private string _typeOfTransaction;
        private string _transactionAmountCurrency;
        private string _accountCurrency;
        private DateTime _transactionDateTime;
        private double _transactionAmountInAccountCurrency;
        private double _balanceAfterTheTransaction;

        public string AccountNumber
        {
            get => _accountNumber;
            set { _accountNumber = value; OnPropertyChanged(nameof(AccountNumber)); }
        }

        public double TransactionAmount
        {
            get => _transactionAmount;
            set { _transactionAmount = value; OnPropertyChanged(nameof(TransactionAmount)); }
        }

        public string TypeOfTransaction
        {
            get => _typeOfTransaction;
            set { _typeOfTransaction = value; OnPropertyChanged(nameof(TypeOfTransaction)); }
        }

        public string TransactionAmountCurrency
        {
            get => _transactionAmountCurrency;
            set { _transactionAmountCurrency = value; OnPropertyChanged(nameof(TransactionAmountCurrency)); }
        }

        public string AccountCurrency
        {
            get => _accountCurrency;
            set { _accountCurrency = value; OnPropertyChanged(nameof(AccountCurrency)); }
        }

        public DateTime TransactionDateTime
        {
            get => _transactionDateTime;
            set { _transactionDateTime = value; OnPropertyChanged(nameof(TransactionDateTime)); }
        }

        public double TransactionAmountInAccountCurrency
        {
            get => _transactionAmountInAccountCurrency;
            set { _transactionAmountInAccountCurrency = value; OnPropertyChanged(nameof(TransactionAmountInAccountCurrency)); }
        }

        public double BalanceAfterTheTransaction
        {
            get => _balanceAfterTheTransaction;
            set { _balanceAfterTheTransaction = value; OnPropertyChanged(nameof(BalanceAfterTheTransaction)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
