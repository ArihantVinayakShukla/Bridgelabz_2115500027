using System;

// Define a class to represent a circle
class Circle
{
    // Private field to store the radius of the circle
    private double radius;

    // Constructor to initialize the circle's radius
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate the area of the circle
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate the circumference of the circle
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    // Method to display circle details
    public void DisplayCircleDetails()
    {
        Console.WriteLine("\nCircle Details:");
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }

    // Main method - Entry point of the program
    static void Main(string[] args)
    {
        // Take radius input from the user
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Create a Circle object and display details
        Circle circle = new Circle(radius);
        circle.DisplayCircleDetails();
    }
}