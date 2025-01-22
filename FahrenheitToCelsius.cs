using System;

class FahrenheitToCelsius
{
    // Method to convert temperature from Fahrenheit to Celsius
    static void ConvertFahrenheitToCelsius(double fahrenheit)
    {
        // Conversion formula: (°F − 32) × 5/9 = °C
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Print the converted temperature
        Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsius + " Celsius");
    }

    // Main method to take user input and call the conversion method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter temperature in Fahrenheit:");
        double fahrenheit = double.Parse(Console.ReadLine()); 

        // Call the conversion method
        ConvertFahrenheitToCelsius(fahrenheit);
    }
}
