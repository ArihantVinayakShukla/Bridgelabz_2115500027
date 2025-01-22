using System;

class DoubleOperations
{
    // Method to perform and display operations on double values
    static void PerformDoubleOperations(double a, double b, double c)
    {
        // Operation 1: Addition and multiplication
        double result1 = a + b * c;

        // Operation 2: Multiplication and addition
        double result2 = a * b + c;

        // Operation 3: Division and addition
        double result3 = c + a / b;

        // Print all results
        Console.WriteLine("The results of Double Operations are " + result1 + ", " + result2 + ", and " + result3);
    }

    // Main method to take inputs and call the operation method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three double values:");
        double a = double.Parse(Console.ReadLine()); 
        double b = double.Parse(Console.ReadLine()); 
        double c = double.Parse(Console.ReadLine()); 

        // Call the method to perform operations
        PerformDoubleOperations(a, b, c);
    }
}
