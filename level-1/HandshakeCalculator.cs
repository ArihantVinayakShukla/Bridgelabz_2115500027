using System;
class HandshakeCalculator {
    static void Main(string[] args) {
        // Get number of students from user
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        
        // Calculate maximum possible handshakes
        int maxHandshakes = CalculateMaxHandshakes(numberOfStudents);
        
        // Print the maximum number of handshakes
        Console.WriteLine(string.Format("Maximum possible handshakes among {0} students is {1}", 
                                numberOfStudents, maxHandshakes));
    }

    static int CalculateMaxHandshakes(int n) {
        // Calculate maximum handshakes using combination formula: (n * (n-1)) / 2
        return (n * (n - 1)) / 2;
    }
}