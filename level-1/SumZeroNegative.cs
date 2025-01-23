using System;

public class SumZeroNegative
{
    public static void CalculateSum()
    {
        double total = 0.0;
        double userInput;

        while (true)
        {
            Console.Write("Enter a number: ");
            userInput = Convert.ToDouble(Console.ReadLine());

            if (userInput == 0 || userInput < 0)
                break;

            total += userInput;
        }

        Console.WriteLine("Total sum: " + total);
    }

    public static void Main()
    {
        CalculateSum();
    }
}