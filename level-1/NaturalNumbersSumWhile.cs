using System;

public class NaturalNumbersSumWhile
{
    public static void CalculateSum(int n)
    {
        // Compute sum using while loop
        int whileLoopSum = 0;
        int counter = 1;
        while (counter <= n)
        {
            whileLoopSum += counter;
            counter++;
        }

        // Compute sum using formula
        int formulaSum = n * (n + 1) / 2;

        // Compare results
        Console.WriteLine("Sum using while loop: " + whileLoopSum);
        Console.WriteLine("Sum using formula: " + formulaSum);
        Console.WriteLine("Results match: " + (whileLoopSum == formulaSum));
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