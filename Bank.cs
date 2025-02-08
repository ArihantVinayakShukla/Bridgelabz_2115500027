using System;

// Base class representing a Bank Account
public abstract class BankAccount
{
    // Private fields for encapsulation
    private string accountNumber;
    private decimal balance;

    // Constructor to initialize bank account properties
    public BankAccount(string accountNumber, decimal balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    // Public property for AccountNumber
    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    // Public property for Balance
    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    // Abstract method to be implemented by derived classes
    public abstract string DisplayAccountType();

    // Virtual method to display account information
    public virtual string DisplayInfo()
    {
        return "Account Number: " + AccountNumber + ", Balance: $" + Balance;
    }
}

// SavingsAccount class inheriting from BankAccount
public class SavingsAccount : BankAccount
{
    // Private field specific to SavingsAccount
    private decimal interestRate;

    // Constructor calling base class constructor
    public SavingsAccount(string accountNumber, decimal balance, decimal interestRate) 
        : base(accountNumber, balance)
    {
        this.interestRate = interestRate;
    }

    // Public property for InterestRate
    public decimal InterestRate
    {
        get { return interestRate; }
        set { interestRate = value; }
    }

    // Implementation of DisplayAccountType for SavingsAccount
    public override string DisplayAccountType()
    {
        return "Account Type: Savings Account, Interest Rate: " + InterestRate + "%";
    }

    // Override DisplayInfo to include savings account information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", " + DisplayAccountType();
    }
}

// CheckingAccount class inheriting from BankAccount
public class CheckingAccount : BankAccount
{
    // Private field specific to CheckingAccount
    private decimal withdrawalLimit;

    // Constructor calling base class constructor
    public CheckingAccount(string accountNumber, decimal balance, decimal withdrawalLimit) 
        : base(accountNumber, balance)
    {
        this.withdrawalLimit = withdrawalLimit;
    }

    // Public property for WithdrawalLimit
    public decimal WithdrawalLimit
    {
        get { return withdrawalLimit; }
        set { withdrawalLimit = value; }
    }

    // Implementation of DisplayAccountType for CheckingAccount
    public override string DisplayAccountType()
    {
        return "Account Type: Checking Account, Withdrawal Limit: $" + WithdrawalLimit;
    }

    // Override DisplayInfo to include checking account information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", " + DisplayAccountType();
    }
}

// FixedDepositAccount class inheriting from BankAccount
public class FixedDepositAccount : BankAccount
{
    // Private fields specific to FixedDepositAccount
    private int termMonths;
    private decimal maturityAmount;

    // Constructor calling base class constructor
    public FixedDepositAccount(string accountNumber, decimal balance, int termMonths, decimal maturityAmount) 
        : base(accountNumber, balance)
    {
        this.termMonths = termMonths;
        this.maturityAmount = maturityAmount;
    }

    // Implementation of DisplayAccountType for FixedDepositAccount
    public override string DisplayAccountType()
    {
        return "Account Type: Fixed Deposit Account, Term: " + termMonths + " months, Maturity Amount: $" + maturityAmount;
    }

    // Override DisplayInfo to include fixed deposit account information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", " + DisplayAccountType();
    }
}

// Main Program to demonstrate functionality
class Program
{
    static void Main(string[] args)
    {
        SavingsAccount savings = new SavingsAccount("SA001", 1000.00m, 2.5m);
        CheckingAccount checking = new CheckingAccount("CA001", 2500.00m, 1000.00m);
        FixedDepositAccount fd = new FixedDepositAccount("FDA001", 5000.00m, 12, 5250.00m);

        Console.WriteLine(savings.DisplayInfo());
        Console.WriteLine(checking.DisplayInfo());
        Console.WriteLine(fd.DisplayInfo());
    }
}