using System;
using System.Collections.Generic;
using System.Linq;

public class Transaction
{
    public float Amount { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; }

    public Transaction(float amount, string type)
    {
        if (amount <= 0)
        {
            throw new Exception("Amount must be greater than zero.");
        }

        Amount = amount;
        Type = type;
        Date = DateTime.Now;
    }
}

public interface TransactionsUse
{
    public List<Transaction> GetTransactions();
}

public class BankAccount: TransactionsUse
{
    private static int accountsCount = 0;
    public int Id { get; private set; }
    private List<Transaction> _transactions;

    public BankAccount()
    {
        this.Id = ++accountsCount;
        this._transactions = new List<Transaction>();
    }

    public void Deposit(float amount)
    {
        if (amount <= 0)
        {
            throw new Exception("Deposit amount must be positive.");
        }
        this._transactions.Add(new Transaction(amount, "Deposit"));
    }

    public void Withdraw(float amount)
    {
        if (amount <= 0)
        {
            throw new Exception("Withdrawal amount must be positive.");
        }

        if (amount > this.getBalance())
        {
            throw new Exception("Insufficient funds.");
        }

        this._transactions.Add(new Transaction(amount, "Withdraw"));
    }

    public float getBalance()
    {
        return _transactions.Where(t => t.Type == "Deposit").Sum(t => t.Amount) -
               _transactions.Where(t => t.Type == "Withdraw").Sum(t => t.Amount);
    }


    public List<Transaction> GetTransactions()
    {
        return this._transactions;
    }
}
