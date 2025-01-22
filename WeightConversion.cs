using System;

class WeightConversion
{
    // Method to convert weight from pounds to kilograms
    static void ConvertPoundsToKilograms(double pounds)
    {
        // Conversion factor: 1 pound = 2.2 kg
        double kilograms = pounds / 2.2;

        // Print the converted weight
        Console.WriteLine("The weight of the person in pounds is " + pounds + " and in kg is " + kilograms);
    }

    // Main method to take input and call the conversion method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the weight in pounds:");
        double pounds = double.Parse(Console.ReadLine()); 

        // Call the method to convert weight
        ConvertPoundsToKilograms(pounds);
    }
}
