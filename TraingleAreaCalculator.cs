using System;
class TriangleAreaCalculator {
    static void Main(string[] args) {
        // Get base and height from user
        Console.WriteLine("Enter the base of triangle (in inches):");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the height of triangle (in inches):");
        double height = Convert.ToDouble(Console.ReadLine());
        
        // Calculate areas in square inches and square centimeters
        double areaInches = CalculateArea(baseLength, height);
        double areaCm = ConvertToSquareCm(areaInches);
        
        // Print the areas
        Console.WriteLine(string.Format("The area of triangle is {0:F2} square inches and {1:F2} square centimeters", 
                                areaInches, areaCm));
    }

    static double CalculateArea(double baseLength, double height) {
        // Calculate area using formula: (1/2) * base * height
        return 0.5 * baseLength * height;
    }

    static double ConvertToSquareCm(double squareInches) {
        // Convert square inches to square centimeters (1 sq inch = 6.4516 sq cm)
        return squareInches * 6.4516;
    }
}