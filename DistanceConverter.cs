using System;
class DistanceConverter {
    static void Main(string[] args) {
        // Create Scanner object for reading user input
        Console.WriteLine("Enter distance in kilometers:");
        
        // Read the distance in kilometers from user
        double km = Convert.ToDouble(Console.ReadLine());
        
        // Calculate the equivalent distance in miles
        double miles = ConvertKmToMiles(km);
        
        // Print the converted distance
        Console.WriteLine(string.Format("The total miles is {0:F2} mile for the given {1} km", 
                                miles, km));
    }

    static double ConvertKmToMiles(double km) {
        // Convert kilometers to miles using the conversion factor 1 mile = 1.6 km
        return km / 1.6;
    }
}