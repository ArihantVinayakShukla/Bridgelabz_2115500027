using System;

public class LeapYearChecker
{
    public static void CheckLeapYear(int year)
    {
        // First method with multiple if-else statements
        if (year < 1582)
        {
            Console.WriteLine("Year is before Gregorian calendar.");
            return;
        }
        
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("Leap Year");
                }
                else
                {
                    Console.WriteLine("Not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Leap Year");
            }
        }
        else
        {
            Console.WriteLine("Not a Leap Year");
        }

        // Second method with single if condition
        bool isLeapYear = (year >= 1582) && 
                          ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0));
        
        Console.WriteLine("Single Condition Check: " + 
            (isLeapYear ? "Leap Year" : "Not a Leap Year"));
    }

    public static void Main()
    {
        Console.Write("Enter a year: ");
        int inputYear = Convert.ToInt32(Console.ReadLine());
        CheckLeapYear(inputYear);
    }
}