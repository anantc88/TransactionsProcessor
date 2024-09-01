using System;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TestTask.ViewModel;
using TestTask.Model;
using TestTask.Data;
using System.Configuration;
using System.Reflection;
using TestTask.Logger;
using System.Transactions;

namespace TestTask.View
{
    public partial class MainForm : Form
    {
        private BindingList<TransactionViewModel> _transactions;
        private BindingList<TransactionViewModel> _listTransactions;
        private List<ExchangeRate> _exchangeRates;
        private bool _isProcessing;
        string transFile = ConfigurationManager.AppSettings["Transactions"]?.ToString();
        string exchangeRatesFile = ConfigurationManager.AppSettings["ExchangeRates"]?.ToString();

        public MainForm()
        {
            InitializeComponent();
            Logging.LogInfo("Application started.");
            _transactions = new BindingList<TransactionViewModel>();
            _listTransactions = new BindingList<TransactionViewModel>();
            dataGridViewTransactions.DataSource = _listTransactions;
            dataGridViewTransactions.CellDoubleClick += DataGridViewTransactions_CellDoubleClick;
        }
        private void DataGridViewTransactions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < _transactions.Count) // Ensuring a valid row is double-clicked
                {
                    var selectedTransaction = _transactions[e.RowIndex];
                    var detailForm = new TransactionDetailForm(selectedTransaction);
                    Logging.LogInfo("Displaying details.");
                    detailForm.ShowDialog(); 
                }
            }
            catch(Exception ex)
            {
                Logging.LogError("Error in loading details - "+ex.ToString());
                MessageBox.Show("Error occurred while loading details.");
            }
            
        }
        private async void buttonProcess_Click(object sender, EventArgs e)
        {                        
            _isProcessing = true;
            buttonProcess.Enabled = false;
            buttonCancel.Enabled = true;
            try
            {
                Logging.LogInfo("Loading transactions from JSON.");
                Logging.LogInfo("Transactions file - "+transFile);
                var transactionsToProcess = await JsonDataAccess.LoadTransactionsAsync(transFile);
                Logging.LogInfo("Loading exchange rates from JSON");
                Logging.LogInfo("Exchange Rates file - "+exchangeRatesFile);
                _exchangeRates = await JsonDataAccess.LoadExchangeRatesAsync(exchangeRatesFile);

                int totalCount = transactionsToProcess.Count;
                progressBar1.Maximum = totalCount > 100 ? 100 : totalCount;
                progressBar1.Value = 0;
                int counter = 0;
                double balance = 0;
                foreach (var trans in transactionsToProcess)
                {
                    var exchangeRate = _exchangeRates.FirstOrDefault(er => er.BusinesDay.Date == trans.TransactionDateTime.Date);
                    if (exchangeRate == null)
                    {
                        continue; // Skip if no exchange rate available for the transaction date
                    }

                    TransactionViewModel transaction = new TransactionViewModel
                    {
                        AccountNumber = trans.AccountNumber,
                        TransactionAmount = trans.TransactionAmount,
                        TypeOfTransaction = trans.TypeOfTransaction,
                        TransactionAmountCurrency = trans.TransactionAmountCurrency,
                        AccountCurrency = trans.AccountCurrency,
                        TransactionDateTime = trans.TransactionDateTime,
                        TransactionAmountInAccountCurrency = 0,
                        BalanceAfterTheTransaction = 0
                    };
                    if (!_isProcessing)
                    {
                        break;
                    }
                    Logging.LogInfo("Converting currency for transaction - " + transaction.TransactionDateTime.ToString());
                    transaction.TransactionAmountInAccountCurrency = ConvertCurrency(trans.TransactionAmount, trans.TransactionAmountCurrency, trans.AccountCurrency, exchangeRate);

                    Logging.LogInfo("Computing balance for transaction - "+transaction.TransactionDateTime.ToString());
                    balance = ComputeBalance(balance, transaction);
                    transaction.BalanceAfterTheTransaction = balance;

                    _transactions.Add(transaction);
                    _listTransactions = _transactions;
                    double percentageDone = ((double)_listTransactions.Count / transactionsToProcess.Count) * 100;
                    dataGridViewTransactions.DataSource = _listTransactions;
                    counter++;
                    if (counter <= 100)
                    {
                        progressBar1.Value = counter;
                    }
                    else
                    {
                        counter = 0;
                        totalCount = totalCount - 100;
                        progressBar1.Maximum = totalCount > 100 ? 100 : totalCount;
                        progressBar1.Value = counter;
                    }
                    Math.Round(percentageDone, 3);
                    lblNumOfRecordsProcessed.Text = "Processed:" + counter.ToString() + "/" + progressBar1.Maximum.ToString();
                    lblTotalUploaded.Text = "Total Uploaded:" + _listTransactions.Count.ToString() + "/" + transactionsToProcess.Count.ToString();
                    lblPercentage.Text = "%age Uploaded:" + percentageDone.ToString("F3") + "%";
                    await Task.Delay(500); 
                }
            }
            catch(Exception ex)
            {
                
                Logging.LogError("Error in loading records to grid - " + ex.ToString());
                MessageBox.Show("An unexpected error occurred while loading data. Please try again later.");
            }
            finally
            {
                _isProcessing = false;
                buttonProcess.Enabled = true;
                buttonCancel.Enabled = false;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Logging.LogInfo("Cancelled loading of transactions to grid");
            _isProcessing = false;
        }

        public double ConvertCurrency(double amount, string fromCurrency, string toCurrency, ExchangeRate exchangeRate)
        {
            double rate = 1.0;
            try
            {
                if (fromCurrency == "USD" && toCurrency == "EUR")
                    rate = 1 / exchangeRate.USDrate;
                else if (fromCurrency == "EUR" && toCurrency == "USD")
                    rate = exchangeRate.USDrate;
                else if (fromCurrency == "INR" && toCurrency == "EUR")
                    rate = exchangeRate.EuroRate;
                else if (fromCurrency == "EUR" && toCurrency == "INR")
                    rate = 1 / exchangeRate.EuroRate;
                else if (fromCurrency == "USD" && toCurrency == "INR")
                    rate = 1 / exchangeRate.USDrate;
                else if (fromCurrency == "INR" && toCurrency == "USD")
                    rate = exchangeRate.USDrate;

                Logging.LogInfo("Rate of conversion from "+fromCurrency+" to "+toCurrency+" is "+rate.ToString());
                return amount * rate;

            }
            catch(Exception ex)
            {
                Logging.LogError("Error in conversion - " + ex.ToString());
                return 0;
            }
            
        }

        public double ComputeBalance(double currentBalance, TransactionViewModel transaction)
        {
            try
            {
                return transaction.TypeOfTransaction.ToLower() == "credit"
                ? currentBalance + transaction.TransactionAmountInAccountCurrency
                : currentBalance - transaction.TransactionAmountInAccountCurrency;
            }
            catch(Exception ex)
            {
                Logging.LogError("Error in computing balance - " + ex.ToString());
                MessageBox.Show("Error in computing balance for the transaction - " + transaction.TransactionDateTime.ToString());
                return 0;
            }
            
        }

    }
}
