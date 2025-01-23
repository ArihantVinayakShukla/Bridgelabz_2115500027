using System;

public class Calculator
{
    public static void Compute(double first, double second, string op)
    {
        // Variable to store the result of the operation
        double result;

        // Perform the operation based on the operator provided
        switch (op)
        {
            case "+":
                // Addition
                result = first + second;
                Console.WriteLine("Result: " + result);
                break;
            case "-":
                // Subtraction
                result = first - second;
                Console.WriteLine("Result: " + result);
                break;
            case "*":
                // Multiplication
                result = first * second;
                Console.WriteLine("Result: " + result);
                break;
            case "/":
                // Division with a check to prevent division by zero
                if (second == 0)
                    Console.WriteLine("Error: Division by zero");
                else
                {
                    result = first / second;
                    Console.WriteLine("Result: " + result);
                }
                break;
            default:
                // Handle invalid operator input
                Console.WriteLine("Error: Invalid operator");
                break;
        }
    }

    public static void Main()
    {
        // Prompt the user to input the first number
        Console.Write("Enter first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to input the second number
        Console.Write("Enter second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to input the operator
        Console.Write("Enter operator (+, -, *, /): ");
        string operation = Console.ReadLine();

        // Call the Compute method to perform the calculation
        Compute(firstNumber, secondNumber, operation);
    }
}
