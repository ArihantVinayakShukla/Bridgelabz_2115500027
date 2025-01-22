using System;

class IntOperations
{
    // Method to perform and display integer operations
    static void PerformIntOperations(int a, int b, int c)
    {
        // Operation 1: Addition and multiplication
        int result1 = a + b * c;

        // Operation 2: Multiplication and addition
        int result2 = a * b + c;

        // Operation 3: Division and addition
        int result3 = c + a / b;

        // Operation 4: Modulus and addition
        int result4 = a % b + c;

        // Print all results
        Console.WriteLine("The results of Int Operations are " + result1 + ", " + result2 + ", " + result3 + ", and " + result4);
    }

    // Main method to take inputs and call the operation method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three integers:");
        int a = int.Parse(Console.ReadLine()); 
        int b = int.Parse(Console.ReadLine()); 
        int c = int.Parse(Console.ReadLine()); 

        // Call the method to perform integer operations
        PerformIntOperations(a, b, c);
    }
}
