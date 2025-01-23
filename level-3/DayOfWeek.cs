using System;

public class DayOfWeek
{
    public static void FindDayOfWeek(int month, int day, int year)
    {
        // Calculate year adjustments based on the given formula
        int y0 = year - (14 - month) / 12;

        // Adjust for leap years and century corrections
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;

        // Convert the month into an adjusted value
        int m0 = month + 12 * ((14 - month) / 12) - 2;

        // Calculate the day of the week using Zeller's Congruence formula
        int d0 = (day + x + 31 * m0 / 12) % 7;

        // Output the day of the week as a numeric value
        Console.WriteLine("Day of the week: " + d0);
    }

    public static void Main(string[] args)
    {
        // Check if the user has provided all necessary command-line arguments
        if (args.Length != 3)
        {
            Console.WriteLine("Please provide month, day, and year as command-line arguments.");
            return;
        }

        // Parse the month, day, and year from the command-line arguments
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);
        int year = int.Parse(args[2]);

        // Call the FindDayOfWeek method to calculate and display the day of the week
        FindDayOfWeek(month, day, year);
    }
}
