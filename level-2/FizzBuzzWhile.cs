using System;

public class FizzBuzzWhile
{
    public static void PrintFizzBuzz(int number)
    {
        // Initialize the loop counter
        int i = 1;

        // Loop until the counter exceeds the given number
        while (i <= number)
        {
            // Check if the current number is divisible by both 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            // Check if the current number is divisible by 3
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            // Check if the current number is divisible by 5
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            // If not divisible by 3 or 5, print the number
            else
                Console.WriteLine(i);

            // Increment the loop counter
            i++;
        }
    }

    public static void Main()
    {
        // Get user input for the number
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        // Call the PrintFizzBuzz method to generate the output
        PrintFizzBuzz(inputNumber);
    }
}