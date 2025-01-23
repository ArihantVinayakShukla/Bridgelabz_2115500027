using System;

public class SingleLeapYearChecker
{
    public static void CheckLeapYear(int year)
    {
        bool isLeapYear = (year >= 1582) && ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0));
        Console.WriteLine(isLeapYear ? "Leap Year" : "Not a Leap Year");
    }

    public static void Main()
    {
        Console.Write("Enter a year: ");
        int inputYear = Convert.ToInt32(Console.ReadLine());
        CheckLeapYear(inputYear);
    }
}