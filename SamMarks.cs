using System;

class SamMarks {
    static void Main(string[] args) {
        Console.WriteLine("Sam's average mark in PCM is " + CalculateAverage(94, 95, 96) + "%");
    }

    // Method to calculate average marks
    static double CalculateAverage(int math, int physics, int chemistry) {
        // Add the marks and calculate the average
        return (math + physics + chemistry) / 3.0;
    }
}
