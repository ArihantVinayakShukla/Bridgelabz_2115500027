using System;

class ConvertDistance {
    static void Main(string[] args) {
        Console.WriteLine("The distance 10.8 km in miles is " + ConvertToMiles(10.8));
    }

    // Method to convert kilometers to miles
    static double ConvertToMiles(double kilometers) {
        // 1 km = 1.6 miles
        return kilometers / 1.6;
    }
}
