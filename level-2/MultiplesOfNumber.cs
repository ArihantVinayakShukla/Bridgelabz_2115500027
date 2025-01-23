using System;

public class MultiplesOfNumber
{
    public static void PrintMultiples(int number)
    {
        Console.WriteLine("Multiples of " + number + " below 100:");

        // Loop from 100 to 1 (in reverse order)
        for (int i = 100; i >= 1; i--)
        {
            // Check if the current number is a multiple of the given number
            if (i % number == 0)
            {
                // If so, print the multiple
                Console.WriteLine(i);

                // Skip the rest of the loop iterations
                continue;
            }
        }
    }

    public static void Main()
    {
        // Get user input for the number
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        // Call the PrintMultiples method to display the multiples
        PrintMultiples(inputNumber);
    }
}