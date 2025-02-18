using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode;

public class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentException("Initial balance cannot be negative");
        }
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be positive");
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }
        Balance -= amount;
    }
}
