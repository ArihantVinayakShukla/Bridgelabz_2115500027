using System;

namespace BankAccountSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a regular bank account
            BankAccount account = new BankAccount("1001", "John Doe", 1000.00);
            account.DisplayInfo();
            account.Deposit(500);
            account.Withdraw(200);

            // Create a savings account
            SavingsAccount savings = new SavingsAccount("2001", "Jane Smith", 2000.00, 0.025);
            savings.DisplayInfo();
            savings.AddInterest();
        }
    }

    public class BankAccount
    {
        // Public member - accessible from anywhere
        public string accountNumber;
        
        // Protected member - accessible in this class and derived classes
        protected string accountHolder;
        
        // Private member - accessible only within this class
        private double balance;

        // Constructor
        public BankAccount(string accountNumber, string accountHolder, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = initialBalance;
        }

        // Public methods to access and modify private balance
        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                
                Console.WriteLine("Deposited $" + amount.ToString("F2") + ". New balance: $" + balance.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                
                Console.WriteLine("Withdrawn $" + amount.ToString("F2") + ". New balance: $" + balance.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        // Public method to display account information
        public virtual void DisplayInfo()
        {
            Console.WriteLine("\nAccount Information:");
            
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder: " + accountHolder);
            Console.WriteLine("Balance: $" + balance.ToString("F2"));
        }
    }

    // Derived class demonstrating protected member access
    public class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(string accountNumber, string accountHolder, double initialBalance, double interestRate)
            : base(accountNumber, accountHolder, initialBalance)
        {
            this.interestRate = interestRate;
        }

        // Method to add interest
        public void AddInterest()
        {
            double interest = GetBalance() * interestRate;
            Deposit(interest);
            
            Console.WriteLine("Added interest: $" + interest.ToString("F2"));
        }

        // Override display method to include interest rate
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            
            Console.WriteLine("Interest Rate: " + interestRate.ToString("P2"));
        }
    }
}
