using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPW211_UnitTestStarterCode;


namespace CPW211_UnitTestStarterCodeTests.Tests;

[TestClass()]
public class BankAccountTests
{
    [TestMethod]
    [DataRow(100)]
    [DataRow(0)]
    [DataRow(1000.50)]
    public void Constructor_InitialBalance_SetsBalance(double initialBalance)
    {
        // Arrange & Act
        BankAccount account = new BankAccount(initialBalance);

        // Assert
        Assert.AreEqual(initialBalance, account.Balance);
    }

    [TestMethod]
    [DataRow(100, 50)]
    [DataRow(0, 100)]
    [DataRow(1000.50, 500.25)]
    public void Deposit_ValidAmount_IncreasesBalance(double initialBalance, double depositAmount)
    {
        // Arrange
        BankAccount account = new BankAccount(initialBalance);
        double expectedBalance = initialBalance + depositAmount;

        // Act
        account.Deposit(depositAmount);

        // Assert
        Assert.AreEqual(expectedBalance, account.Balance);
    }

    [TestMethod]
    [DataRow(0)]
    [DataRow(-100)]
    public void Deposit_ZeroOrNegativeAmount_ThrowsArgumentException(double depositAmount)
    {
        // Arrange
        BankAccount account = new BankAccount(100);

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => account.Deposit(depositAmount));
    }

    [TestMethod]
    [DataRow(100, 50)]
    [DataRow(1000, 500)]
    [DataRow(75.50, 25.50)]
    public void Withdraw_ValidAmount_DecreasesBalance(double initialBalance, double withdrawAmount)
    {
        // Arrange
        BankAccount account = new BankAccount(initialBalance);
        double expectedBalance = initialBalance - withdrawAmount;

        // Act
        account.Withdraw(withdrawAmount);

        // Assert
        Assert.AreEqual(expectedBalance, account.Balance);
    }

    [TestMethod]
    [DataRow(100, 150)]
    [DataRow(50, 75)]
    public void Withdraw_InsufficientFunds_ThrowsInvalidOperationException(double initialBalance, double withdrawAmount)
    {
        // Arrange
        BankAccount account = new BankAccount(initialBalance);

        // Act & Assert
        Assert.ThrowsException<InvalidOperationException>(() => account.Withdraw(withdrawAmount));
    }
}
