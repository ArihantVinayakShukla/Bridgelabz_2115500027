using System;
class BasicCalculator {
    static void Main(string[] args) {
        // Get first number from user
        Console.WriteLine("Enter first number:");
        double number1 = Convert.ToDouble(Console.ReadLine());
        
        // Get second number from user
        Console.WriteLine("Enter second number:");
        double number2 = Convert.ToDouble(Console.ReadLine());
        
        // Perform all arithmetic operations
        double sum = Add(number1, number2);
        double difference = Subtract(number1, number2);
        double product = Multiply(number1, number2);
        double quotient = Divide(number1, number2);
        
        // Print all results
        Console.WriteLine(string.Format("The addition, subtraction, multiplication and division value of 2 numbers {0} and {1} is {2}, {3}, {4}, and {5:F2}", 
                                number1, number2, sum, difference, product, quotient));
    }

    static double Add(double a, double b) {
        // Add two numbers
        return a + b;
    }

    static double Subtract(double a, double b) {
        // Subtract second number from first
        return a - b;
    }

    static double Multiply(double a, double b) {
        // Multiply two numbers
        return a * b;
    }

    static double Divide(double a, double b) {
        // Divide first number by second
        return a / b;
    }
}