using System;

class TemperatureConverter
{
    static void Main(string[] args)
    {
        // Create instance of Converter
        Converter processor = new Converter();
        processor.ConvertTemperature();
    }
}

class Converter
{
    // Method to handle temperature conversion
    public void ConvertTemperature()
    {
        // Display menu
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.Write("Enter your choice (1/2): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Get temperature from user
        Console.Write("Enter temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        // Convert and display result
        if (choice == 1)
        {
            double celsius = (temperature - 32) * 5 / 9;
            Console.WriteLine(temperature + " Fahrenheit = " + celsius + " Celsius");
        }
        else if (choice == 2)
        {
            double fahrenheit = (temperature * 9 / 5) + 32;
            Console.WriteLine(temperature + " Celsius = " + fahrenheit + " Fahrenheit");
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}