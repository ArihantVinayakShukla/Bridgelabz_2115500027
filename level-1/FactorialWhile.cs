using System;

public class FactorialWhile
{
    public static void CalculateFactorial(int number)
    {
        // Initialize factorial
        long factorial = 1;
        int counter = 1;

        // Calculate factorial using while loop
        while (counter <= number)
        {
            factorial *= counter;
            counter++;
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