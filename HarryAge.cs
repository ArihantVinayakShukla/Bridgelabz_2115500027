using System;

class HarryAge {
    static void Main(string[] args) {
        // Calculate and display Harry's age
        Console.WriteLine("Harry's age in 2024 is " + CalculateAge(2000));
    }

    // Method to calculate age
    static int CalculateAge(int birthYear) {
        // Subtract birth year from the current year
        return 2024 - birthYear;
    }
}
