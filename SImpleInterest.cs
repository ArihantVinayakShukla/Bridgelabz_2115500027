using System;

class SimpleInterest
{
    // Method to calculate and display simple interest
    static void CalculateSimpleInterest(double principal, double rate, double time)
    {
        // Formula for simple interest
        double interest = (principal * rate * time) / 100;

        // Print the simple interest
        Console.WriteLine("The Simple Interest is " + interest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
    }

    // Main method to take inputs and call the calculation method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Principal amount:");
        double principal = double.Parse(Console.ReadLine()); 

        Console.WriteLine("Enter the Rate of Interest:");
        double rate = double.Parse(Console.ReadLine()); 

        Console.WriteLine("Enter the Time period:");
        double time = double.Parse(Console.ReadLine()); 

        // Call the method to calculate simple interest
        CalculateSimpleInterest(principal, rate, time);
    }
}
