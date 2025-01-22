using System;

class CelsiusToFahrenheit
{
    // Method to convert temperature from Celsius to Fahrenheit
    static void ConvertCelsiusToFahrenheit(double celsius)
    {
        // Conversion formula: (°C × 9/5) + 32 = °F
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Print the converted temperature
        Console.WriteLine("The " + celsius + " Celsius is " + fahrenheit + " Fahrenheit");
    }

    // Main method to take user input and call the conversion method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter temperature in Celsius:");
        double celsius = double.Parse(Console.ReadLine()); 

        // Call the conversion method
        ConvertCelsiusToFahrenheit(celsius);
    }
}
