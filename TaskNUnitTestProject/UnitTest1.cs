using TestTask.View;
using TestTask.Data;
using TestTask.Model;
using TestTask.ViewModel;
namespace TaskNUnitTestProject;

public class Tests
{
    MainForm objform = new();
    [Test]
    public void ConvertCurrency_ShouldConvertCorrectly_FromUSDtoEUR()
    {
        var exchangeRate = new ExchangeRate
        {
            USDrate = 1.05,
            INRrate = 85.09
        };
        var transactionAmount = 100.0;
        var expectedAmountInEUR = transactionAmount / exchangeRate.USDrate;
        double result = objform.ConvertCurrency(transactionAmount, "USD", "EUR", exchangeRate);

        Assert.AreEqual(expectedAmountInEUR, result, 0.01); // Allowing a delta of 0.01 for precision issues
    }

    [Test]
    public void ComputeBalance_ShouldAddBalance_OnCreditTransaction()
    {
        var currentBalance = 1000.0;
        var transaction = new TransactionViewModel
        {
            TypeOfTransaction = "credit",
            TransactionAmountInAccountCurrency = 200.0
        };
        var expectedBalance = currentBalance + transaction.TransactionAmountInAccountCurrency;

        double result = objform.ComputeBalance(currentBalance, transaction);
        Assert.AreEqual(expectedBalance, result);
    }

    [Test]
    public void ComputeBalance_ShouldSubtractBalance_OnDebitTransaction()
    {
        var currentBalance = 1000.0;
        var transaction = new TransactionViewModel
        {
            TypeOfTransaction = "debit",
            TransactionAmountInAccountCurrency = 200.0
        };
        var expectedBalance = currentBalance - transaction.TransactionAmountInAccountCurrency;
                
        double result = objform.ComputeBalance(currentBalance, transaction);
                
        Assert.AreEqual(expectedBalance, result);
    }
}
