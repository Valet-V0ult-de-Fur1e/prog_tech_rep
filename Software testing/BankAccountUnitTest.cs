using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void DepositValidAmount_IncreaseBalance()
    {
        // Arrange
        var account = new BankAccount();
        var depositAmount = 100f;

        // Act
        account.Deposit(depositAmount);

        // Assert
        Assert.That(account.getBalance(), Is.EqualTo(depositAmount));
    }

    [Test]
    public void WithdrawValidAmount_DecreaseBalance()
    {
        // Arrange
        var account = new BankAccount();
        account.Deposit(100f);
        var withdrawAmount = 50f;

        // Act
        account.Withdraw(withdrawAmount);

        // Assert
        Assert.That(account.getBalance(), Is.EqualTo(50f));
    }

    [Test]
    public void WithdrawInsufficientFunds_ThrowException()
    {
        // Arrange
        var account = new BankAccount();
        account.Deposit(100f);
        var withdrawAmount = 150f;

        // Act & Assert
        var ex = Assert.Throws<Exception>(() => account.Withdraw(withdrawAmount));
        Assert.That(ex.Message, Is.EqualTo("Insufficient funds."));
    }

    [Test]
    public void WithdrawInvalidAmount_ThrowException()
    {
        // Arrange
        var account = new BankAccount();
        account.Deposit(100f);

        // Act & Assert
        var ex = Assert.Throws<Exception>(() => account.Withdraw(-50f));
        Assert.That(ex.Message, Is.EqualTo("Amount must be greater than zero."));
    }
    [Test]
    public void WithdrawZeroAmount_ThrowException()
    {
        // Arrange
        var account = new BankAccount();
        account.Deposit(100f);

        // Act & Assert
        var ex = Assert.Throws<Exception>(() => account.Withdraw(0f));
        Assert.That(ex.Message, Is.EqualTo("Amount must be greater than zero."));
    }

    [Test]
    public void GetBalance_ReturnCorrectBalance()
    {
        // Arrange
        var account = new BankAccount();
        account.Deposit(10000f);
        account.Withdraw(50f);

        // Act
        var balance = account.getBalance();

        // Assert
        Assert.That(balance, Is.EqualTo(9950f));
    }

    [Test]
    public void GetTransactions_ReturnExpectedTransactions()
    {
        // Arrange
        var mockAccount = new Mock<TransactionsUse>() ;
        var mockTransactions = new List<Transaction>
        {
            new Transaction(100f, "Deposit"),
            new Transaction(50f, "Withdraw")
        };

        mockAccount.Setup(m => m.GetTransactions()).Returns(mockTransactions);

        // Act
        var transactions = mockAccount.Object.GetTransactions();

        // Assert
        Assert.That(transactions.Count, Is.EqualTo(2));
        Assert.That(transactions.First().Type, Is.EqualTo("Deposit"));
        Assert.That(transactions.Last().Type, Is.EqualTo("Withdraw"));
    }
}
