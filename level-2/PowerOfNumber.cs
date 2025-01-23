using System;

public class PowerOfNumber
{
    public static void CalculatePower(int number, int power)
    {
        // Initialize the result to 1
        int result = 1;

        // Loop from 1 to the given power
        for (int i = 1; i <= power; i++)
        {
            // Multiply the result with the given number
            result *= number;
        }

        // Output the result
        Console.WriteLine($"{number} raised to the power of {power} is {result}");
    }

    public static void Main()
    {
        // Get user input for the number and power
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int inputPower = Convert.ToInt32(Console.ReadLine());

        // Call the CalculatePower method to compute and display the result
        CalculatePower(inputNumber, inputPower);
    }
}