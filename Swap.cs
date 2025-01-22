using System;

class SwapNumbers
{
    // Method to swap two numbers and print the results
    static void Swap(int number1, int number2)
    {
        // Use a temporary variable to swap the values
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Print the swapped numbers
        Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
    }

    // Main method to take inputs, call the swap method, and display results
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int number1 = int.Parse(Console.ReadLine()); 

        Console.WriteLine("Enter the second number:");
        int number2 = int.Parse(Console.ReadLine()); 

        // Call the swap method (doesn't affect the original variables in Main)
        Swap(number1, number2);
    }
}
