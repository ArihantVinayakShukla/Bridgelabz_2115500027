using System;

class BankAccount
{
    // Static variable shared across all instances
    public static string bankName = "Global Bank";
    private static int totalAccounts = 0;

    // Readonly variable to prevent modification after initialization
    public readonly int AccountNumber;
    public string AccountHolderName;
    public double Balance;

    // Constructor using 'this' to resolve ambiguity
    public BankAccount(string AccountHolderName, int AccountNumber, double initialBalance)
    {
        this.AccountHolderName = AccountHolderName;
        this.AccountNumber = AccountNumber; // Readonly, can only be assigned here
        this.Balance = initialBalance;
        totalAccounts++; // Increment total account count
    }

    // Static method to get the total number of accounts
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    // Method to display account details using 'is' operator
    public void DisplayAccountDetails()
    {
        if (this is BankAccount)
        {
            Console.WriteLine("Bank Name: " + bankName);
            Console.WriteLine("Account Holder: " + AccountHolderName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: $" + Balance);
        }
        else
        {
            Console.WriteLine("Invalid account instance.");
        }
    }

    // Example usage
    static void Main()
    {
        BankAccount acc1 = new BankAccount("John Doe", 1001, 5000.00);
        BankAccount acc2 = new BankAccount("Jane Smith", 1002, 7000.00);

        acc1.DisplayAccountDetails();
        acc2.DisplayAccountDetails();

        // Display total number of accounts
        BankAccount.GetTotalAccounts();
    }
}
