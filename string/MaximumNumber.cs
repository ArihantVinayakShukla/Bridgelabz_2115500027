using System;

class MaximumNumbers
{
    static void Main(string[] args)
    {
        // Create instance of NumberProcessor
        NumberProcessor processor = new NumberProcessor();
        processor.FindMaximum();
    }
}

class NumberProcessor
{
    // Method to find maximum number
    public void FindMaximum()
    {
        // Get user input for three numbers
        Console.Write("Enter first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());

        // Find maximum using Math.Max
        int maximum = Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber);

        // Display result
        Console.WriteLine("Maximum number is: " + maximum);
    }
}