using System;

public class SumUntilZero
{
    public static void CalculateSum()
    {
        // Initialize total and input variable
        double total = 0.0;
        double userInput;

        // Continually ask for input until zero is entered
        while (true)
        {
            Console.Write("Enter a number (0 to stop): ");
            userInput = Convert.ToDouble(Console.ReadLine());

            // Break condition
            if (userInput == 0)
                break;

            // Add to total
            total += userInput;
        }

        // Display total
        Console.WriteLine($"Total sum: {total}");
    }

    public static void Main()
    {
        // Call sum calculation method
        CalculateSum();
    }
}