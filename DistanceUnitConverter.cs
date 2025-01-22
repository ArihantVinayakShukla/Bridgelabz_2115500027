using System;
class DistanceUnitConverter {
    static void Main(string[] args) {
        // Get distance in feet from user
        Console.WriteLine("Enter the distance in feet:");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());
        
        // Convert feet to yards and miles
        double yards = ConvertFeetToYards(distanceInFeet);
        double miles = ConvertYardsToMiles(yards);
        
        // Print the converted distances
        Console.WriteLine(string.Format("The distance is {0:F2} yards and {1:F4} miles for {2} feet", 
                                yards, miles, distanceInFeet));
    }

    static double ConvertFeetToYards(double feet) {
        // Convert feet to yards (1 yard = 3 feet)
        return feet / 3.0;
    }

    static double ConvertYardsToMiles(double yards) {
        // Convert yards to miles (1 mile = 1760 yards)
        return yards / 1760.0;
    }
}