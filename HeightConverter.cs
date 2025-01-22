using System;
class HeightConverter {
    static void Main(string[] args) {
        // Ask user for height in centimeters
        Console.WriteLine("Enter your height in centimeters:");
        double heightCm = Convert.ToDouble(Console.ReadLine());
        
        // Convert height to feet and inches
        double totalInches = ConvertCmToInches(heightCm);
        int feet = CalculateFeet(totalInches);
        double inches = CalculateRemainingInches(totalInches);
        
        // Print the converted height
        Console.WriteLine(string.Format("Your Height in cm is {0} while in feet is {1} and inches is {2:F1}", 
                                heightCm, feet, inches));
    }

    static double ConvertCmToInches(double cm) {
        // Convert centimeters to inches using the conversion factor 1 inch = 2.54 cm
        return cm / 2.54;
    }

    static int CalculateFeet(double totalInches) {
        // Calculate complete feet from total inches (1 foot = 12 inches)
        return (int)(totalInches / 12);
    }

    static double CalculateRemainingInches(double totalInches) {
        // Calculate remaining inches after converting to feet
        return totalInches % 12;
    }
}