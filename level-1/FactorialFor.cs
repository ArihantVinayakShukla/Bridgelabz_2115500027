using System;

public class FactorialFor
{
    public static void CalculateFactorial(int number)
    {
        // Initialize factorial
        long factorial = 1;

        // Calculate factorial using for loop
        for (int counter = 1; counter <= number; counter++)
        {
            factorial *= counter;
        }

        // Print result
        Console.WriteLine("Factorial of " + number + " is: " + factorial);
    }

    public static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        if (inputNumber > 0)
        {
            CalculateFactorial(inputNumber);
        }
        else
        {
            Console.WriteLine("Please enter a positive number.");
        }
    }
}