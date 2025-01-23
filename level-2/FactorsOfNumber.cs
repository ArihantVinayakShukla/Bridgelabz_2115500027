using System;

public class FactorsOfNumber
{
    public static void FindFactors(int number)
    {
        Console.WriteLine("Factors of " + number + ":");

        // Loop from 1 to the given number - 1
        for (int i = 1; i < number; i++)
        {
            // Check if the current number is a factor of the given number
            if (number % i == 0)
            {
                // If so, print the factor
                Console.WriteLine(i);
            }
        }
    }

    public static void Main()
    {
        // Get user input for the number
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        // Call the FindFactors method to compute and display the factors
        FindFactors(inputNumber);
    }
}