using System;

class BasicCalculator
{
    static void Main(string[] args)
    {
        // Create instance of Calculator
        Calculator calculator = new Calculator();
        calculator.Calculate();
    }
}

class Calculator
{
    // Method to perform calculations
    public void Calculate()
    {
        // Display menu
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Get two numbers from user
        Console.Write("Enter first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        // Perform calculation based on choice
        double result = 0;
        string operation = "";

        switch (choice)
        {
            case 1:
                result = firstNumber + secondNumber;
                operation = "+";
                break;
            case 2:
                result = firstNumber - secondNumber;
                operation = "-";
                break;
            case 3:
                result = firstNumber * secondNumber;
                operation = "*";
                break;
            case 4:
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                    operation = "/";
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        // Display result
        Console.WriteLine(firstNumber + " " + operation + " " + secondNumber + " = " + result);
    }
}