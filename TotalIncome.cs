using System;

class TotalIncome
{
    // Method to calculate and display total income from salary and bonus
    static void CalculateTotalIncome(double salary, double bonus)
    {
        // Add salary and bonus to compute total income
        double totalIncome = salary + bonus;

        // Print the total income
        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
    }

    // Main method to take inputs and call the calculation method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your salary:");
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter your bonus:");
        double bonus = double.Parse(Console.ReadLine()); 

        // Call the method to calculate total income
        CalculateTotalIncome(salary, bonus);
    }
}
