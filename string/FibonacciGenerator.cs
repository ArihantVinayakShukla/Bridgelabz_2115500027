using System;

class FibonacciGenerator
{
    static void Main(string[] args)
    {
        // Create instance of FibonacciProcessor
        FibonacciProcessor processor = new FibonacciProcessor();
        processor.GenerateFibonacci();
    }
}

class FibonacciProcessor
{
    // Method to generate Fibonacci sequence
    public void GenerateFibonacci()
    {
        // Get number of terms from user
        Console.Write("Enter number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        // Initialize first two numbers
        int firstNumber = 0;
        int secondNumber = 1;

        // Print first two numbers
        Console.Write(firstNumber + " " + secondNumber + " ");

        // Generate remaining numbers
        for (int i = 2; i < terms; i++)
        {
            int nextNumber = firstNumber + secondNumber;
            Console.Write(nextNumber + " ");
            
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
    }
}