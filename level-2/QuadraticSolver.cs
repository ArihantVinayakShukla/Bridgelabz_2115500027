using System;

public class QuadraticSolver
{
    public static void Main(string[] args)
    {
        // Declare variables for coefficients
        double a, b, c;
        
        // Get input from user
        Console.WriteLine("Enter coefficient a:");
        a = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter coefficient b:");
        b = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter coefficient c:");
        c = Convert.ToDouble(Console.ReadLine());
        
        // Find roots
        double[] roots = FindRoots(a, b, c);
        
        // Display results
        if(roots.Length == 0)
        {
            Console.WriteLine("No real roots exist");
        }
        else if(roots.Length == 1)
        {
            Console.WriteLine("One root exists: " + roots[0]);
        }
        else
        {
            Console.WriteLine("Two roots exist: " + roots[0] + " and " + roots[1]);
        }
    }
    
    public static double[] FindRoots(double a, double b, double c)
    {
        // Calculate discriminant
        double delta = Math.Pow(b, 2) - (4 * a * c);
        
        // Check discriminant and return appropriate roots
        if(delta > 0)
        {
            // Two distinct real roots
            double[] roots = new double[2];
            roots[0] = (-b + Math.Sqrt(delta)) / (2 * a);
            roots[1] = (-b - Math.Sqrt(delta)) / (2 * a);
            return roots;
        }
        else if(delta == 0)
        {
            // One real root
            double[] root = new double[1];
            root[0] = -b / (2 * a);
            return root;
        }
        else
        {
            // No real roots
            return new double[0];
        }
    }
}