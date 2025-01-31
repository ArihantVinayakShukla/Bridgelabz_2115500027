using System;

class DateArithmetic
{
    static void Main(string[] args)
    {
        // Create instance of DateProcessor
        DateProcessor processor = new DateProcessor();
        processor.ProcessDate();
    }
}

class DateProcessor
{
    // Method to process date arithmetic
    public void ProcessDate()
    {
        // Get date input from user
        Console.Write("Enter a date (MM/dd/yyyy): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        // Perform date arithmetic
        DateTime result = inputDate
            .AddDays(7)      // Add 7 days
            .AddMonths(1)    // Add 1 month
            .AddYears(2)     // Add 2 years
            .AddDays(-21);   // Subtract 3 weeks (21 days)

        // Display results
        Console.WriteLine("Original Date: " + inputDate.ToShortDateString());
        Console.WriteLine("After calculations: " + result.ToShortDateString());
    }
}