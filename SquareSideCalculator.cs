using System;
class SquareSideCalculator {
    static void Main(string[] args) {
        // Get perimeter input from user
        Console.WriteLine("Enter the perimeter of the square:");
        double perimeter = Convert.ToDouble(Console.ReadLine());
        
        // Calculate the length of one side
        double side = CalculateSide(perimeter);
        
        // Print the length of the side
        Console.WriteLine(string.Format("The length of the side is {0:F2} whose perimeter is {1}", 
                                side, perimeter));
    }

    static double CalculateSide(double perimeter) {
        // Calculate side length using formula: perimeter / 4
        return perimeter / 4;
    }
}