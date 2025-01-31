using System;

class DateFormatting
{
    static void Main(string[] args)
    {
        // Create instance of FormatProcessor
        FormatProcessor processor = new FormatProcessor();
        processor.FormatDate();
    }
}

class FormatProcessor
{
    // Method to format current date
    public void FormatDate()
    {
        // Get current date
        DateTime currentDate = DateTime.Now;

        // Display date in different formats
        Console.WriteLine("Current date in different formats:");
        Console.WriteLine("dd/MM/yyyy: " + currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("yyyy-MM-dd: " + currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("EEE, MMM dd, yyyy: " + currentDate.ToString("ddd, MMM dd, yyyy"));
    }
}