using System;

namespace CircleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create circles using different constructors
            Circle defaultCircle = new Circle();
            Circle customCircle = new Circle(5.0);

            // Display circle information
            Console.WriteLine("Default Circle:");
            defaultCircle.DisplayInfo();

            Console.WriteLine("\nCustom Circle:");
            customCircle.DisplayInfo();
        }
    }

    public class Circle
    {
        // Private field for encapsulation
        private double radius;

        // Default constructor chains to parameterized constructor
        public Circle() : this(1.0)
        {
            // Constructor chaining handles initialization
        }

        // Parameterized constructor
        public Circle(double radius)
        {
            // Assign provided value to radius
            this.radius = radius;
        }

        // Public property with controlled access
        public double Radius
        {
            // Get the radius
            get { return radius; }
            // Private setter to prevent modification outside class
            private set { radius = value; }
        }

        // Method to calculate area
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        // Method to calculate circumference
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        // Method to display circle information
        public void DisplayInfo()
        {
            // Print circle details using string concatenation
            Console.WriteLine("Radius: " + radius.ToString("F2"));
            Console.WriteLine("Area: " + CalculateArea().ToString("F2"));
            Console.WriteLine("Circumference: " + CalculateCircumference().ToString("F2"));
        }
    }
}
