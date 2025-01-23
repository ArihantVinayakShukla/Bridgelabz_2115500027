using System;

public class BMICalculator
{
    // Method to calculate BMI and classify the person based on the given weight and height
    public static void CalculateBMI(double weight, double height)
    {
        // Calculate BMI using formula: BMI = weight / (height * height) in meters squared
        double bmi = weight / Math.Pow(height / 100, 2);
        string status;

        // Classify the person based on the BMI
        if (bmi <= 18.4) { status = "Underweight"; }
        else if (bmi >= 18.5 && bmi <= 24.9) { status = "Normal"; }
        else if (bmi >= 25.0 && bmi <= 39.9) { status = "Overweight"; }
        else { status = "Obese"; }

        // Display the calculated BMI and status
        Console.WriteLine("BMI: " + bmi.ToString("F2"));
        Console.WriteLine("Status: " + status);
    }

    public static void Main()
    {
        // Prompt the user to enter weight and height
        Console.Write("Enter weight (kg): "); double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height (cm): "); double height = Convert.ToDouble(Console.ReadLine());
        CalculateBMI(weight, height);
    }
}