using System;

class DateComparison
{
    static void Main(string[] args)
    {
        // Create instance of ComparisonProcessor
        ComparisonProcessor processor = new ComparisonProcessor();
        processor.CompareDates();
    }
}

class ComparisonProcessor
{
    // Method to compare two dates
    public void CompareDates()
    {
        // Get first date from user
        Console.Write("Enter first date (MM/dd/yyyy): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());

        // Get second date from user
        Console.Write("Enter second date (MM/dd/yyyy): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        // Compare dates
        int comparison = DateTime.Compare(firstDate, secondDate);

        // Display result based on comparison
        if (comparison < 0)
        {
            Console.WriteLine("First date is before second date");
        }
        else if (comparison > 0)
        {
            Console.WriteLine("First date is after second date");
        }
        else
        {
            Console.WriteLine("Both dates are the same");
        }

        // Display the difference in days
        TimeSpan difference = firstDate - secondDate;
        Console.WriteLine("Difference in days: " + Math.Abs(difference.Days));
    }
}