using System;

public class GreatestFactor
{
    public static void FindGreatestFactor(int number)
    {
        // Initialize the greatest factor to 1
        int greatestFactor = 1;

        // Loop from the number - 1 to 1
        for (int i = number - 1; i >= 1; i--)
        {
            // Check if the current number is a factor of the given number
            if (number % i == 0)
            {
                // Update the greatest factor if the current factor is larger
                greatestFactor = i;
                break;
            }
        }

        // Output the greatest factor
        Console.WriteLine("The greatest factor of " + number + " is " + greatestFactor);
    }

    public static void Main()
    {
        // Get user input for the number
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        // Call the FindGreatestFactor method to compute and display the result
        FindGreatestFactor(inputNumber);
    }
}