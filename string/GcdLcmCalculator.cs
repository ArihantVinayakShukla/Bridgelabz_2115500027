using System;

class GcdLcmCalculator
{
    static void Main(string[] args)
    {
        // Create instance of Calculator
        Calculator processor = new Calculator();
        processor.CalculateGcdLcm();
    }
}

class Calculator
{
    // Method to calculate GCD and LCM
    public void CalculateGcdLcm()
    {
        // Get two numbers from user
        Console.Write("Enter first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // Calculate GCD
        int gcd = CalculateGcd(firstNumber, secondNumber);

        // Calculate LCM using GCD
        int lcm = (firstNumber * secondNumber) / gcd;

        // Display results
        Console.WriteLine("GCD of " + firstNumber + " and " + secondNumber + " is " + gcd);
        Console.WriteLine("LCM of " + firstNumber + " and " + secondNumber + " is " + lcm);
    }

    // Method to calculate GCD using recursion
    private int CalculateGcd(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return CalculateGcd(b, a % b);
    }
}