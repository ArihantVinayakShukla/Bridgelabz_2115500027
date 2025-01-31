using System;

class TimeZonesDisplay
{
    static void Main(string[] args)
    {
        // Create instance of TimeProcessor
        TimeProcessor processor = new TimeProcessor();
        processor.DisplayTimeZones();
    }
}

class TimeProcessor
{
    // Method to display times in different zones
    public void DisplayTimeZones()
    {
        // Get current time in UTC
        DateTime currentUtc = DateTime.UtcNow;

        // Get time zone information
        TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        // Convert times
        DateTime gmtTime = TimeZoneInfo.ConvertTimeFromUtc(currentUtc, gmtZone);
        DateTime istTime = TimeZoneInfo.ConvertTimeFromUtc(currentUtc, istZone);
        DateTime pstTime = TimeZoneInfo.ConvertTimeFromUtc(currentUtc, pstZone);

        // Display results
        Console.WriteLine("Current times in different zones:");
        Console.WriteLine("GMT: " + gmtTime.ToString());
        Console.WriteLine("IST: " + istTime.ToString());
        Console.WriteLine("PST: " + pstTime.ToString());
    }
}