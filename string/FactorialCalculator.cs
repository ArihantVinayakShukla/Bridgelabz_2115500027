using System;

class FactorialCalculator
{
    static void Main(string[] args)
    {
        // Create instance of FactorialProcessor
        FactorialProcessor processor = new FactorialProcessor();
        processor.CalculateFactorial();
    }
}

class FactorialProcessor
{
    // Method to calculate factorial
    public void CalculateFactorial()
    {
        // Get number from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Calculate factorial using recursion
        int result = GetFactorial(number);

        // Display result
        Console.WriteLine("Factorial of " + number + " is " + result);
    }

    // Recursive method to calculate factorial
    private int GetFactorial(int number)
    {
        if (number <= 1)
        {
            return 1;
        }
        return number * GetFactorial(number - 1);
    }
}