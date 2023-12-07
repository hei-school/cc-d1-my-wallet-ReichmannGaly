using System;
using System.Collections.Generic;

public class Wallet
{
    private decimal balance;
    private List<string> transactions;

    public Wallet()
    {
        balance = 0;
        transactions = new List<string>();
    
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            transactions.Add($"Deposit: +{amount}");
            Console.WriteLine("\nSuccessful deposit.");
        }
        else 
        {
            Console.WriteLine("\nPlease enter a valid amount!");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            transactions.Add($"Withdrawal: -{amount}");
        }
        else 
        {
            Console.WriteLine("\nInsufficient funds!");
        }
    }

    public List<string> GetTransactions()
    {
        return transactions;
    }
}