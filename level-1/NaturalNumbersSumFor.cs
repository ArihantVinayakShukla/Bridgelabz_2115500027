using System;

public class NaturalNumbersSumFor
{
    public static void CalculateSum(int n)
    {
        // Compute sum using for loop
        int forLoopSum = 0;
        for (int counter = 1; counter <= n; counter++)
        {
            forLoopSum += counter;
        }

        // Compute sum using formula
        int formulaSum = n * (n + 1) / 2;

        // Compare results
        Console.WriteLine("Sum using for loop: " + forLoopSum);
        Console.WriteLine("Sum using formula: " + formulaSum);
        Console.WriteLine("Results match: " + (forLoopSum == formulaSum));
    }

    public static void Main()
    {
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            CalculateSum(number);
        }
        else
        {
            Console.WriteLine("Please enter a positive number.");
        }
    }
}