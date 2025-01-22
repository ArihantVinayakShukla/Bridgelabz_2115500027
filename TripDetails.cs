using System;

class TripDetails
{
    // Method to calculate and display trip details
    static void DisplayTripDetails(string name, string fromCity, string viaCity, string toCity, double distance1, double distance2, double timeTaken)
    {
        // Total distance is the sum of both distances
        double totalDistance = distance1 + distance2;

        // Average speed is total distance divided by time taken
        double averageSpeed = totalDistance / timeTaken;

        // Print the trip details
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Trip: " + fromCity + " -> " + viaCity + " -> " + toCity);
        Console.WriteLine("Total Distance: " + totalDistance + " miles");
        Console.WriteLine("Average Speed: " + averageSpeed + " miles/hour");
    }

    // Main method to take inputs and call the trip details method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine(); 

        Console.WriteLine("Enter the starting city:");
        string fromCity = Console.ReadLine(); 

        Console.WriteLine("Enter the city via which the trip passes:");
        string viaCity = Console.ReadLine(); 

        Console.WriteLine("Enter the destination city:");
        string toCity = Console.ReadLine(); 

        Console.WriteLine("Enter the distance from starting city to via city (in miles):");
        double distance1 = double.Parse(Console.ReadLine()); 

        Console.WriteLine("Enter the distance from via city to destination city (in miles):");
        double distance2 = double.Parse(Console.ReadLine()); 

        Console.WriteLine("Enter the time taken for the journey (in hours):");
        double timeTaken = double.Parse(Console.ReadLine()); 

        // Call the method to display trip details
        DisplayTripDetails(name, fromCity, viaCity, toCity, distance1, distance2, timeTaken);
    }
}
