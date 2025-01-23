using System;

public class AbundantNumberChecker
{
    public static void CheckAbundantNumber(int number)
    {
        // Initialize the sum of divisors to 0
        int sum = 0;

        // Loop through all numbers less than the given number to find divisors
        for (int i = 1; i < number; i++)
        {
            // Check if 'i' is a divisor of the number
            if (number % i == 0)
                sum += i; // Add the divisor to the sum
        }

        // Check if the sum of divisors is greater than the number itself
        Console.WriteLine(sum > number ? "Abundant Number" : "Not an Abundant Number");
    }

    public static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        // Call the CheckAbundantNumber method to check if the number is abundant
        CheckAbundantNumber(inputNumber);
    }
}
