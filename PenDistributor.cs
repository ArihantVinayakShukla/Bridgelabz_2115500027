using System;
class PenDistributor {
    static void Main(string[] args) {
        // Create variables for total number of pens and students
        int totalPens = 14;
        int totalStudents = 3;

        // Calculate how many pens each student will get
        int pensPerStudent = CalculatePensPerStudent(totalPens, totalStudents);

        // Calculate how many pens will be left after distribution
        int remainingPens = CalculateRemainingPens(totalPens, totalStudents);

        // Print the number of pens per student and remaining pens
        Console.WriteLine(string.Format("The Pen Per Student is {0} and the remaining pen not distributed is {1}", 
                                pensPerStudent, remainingPens));
    }

    static int CalculatePensPerStudent(int pens, int students) {
        // Calculate pens per student by dividing total pens by number of students
        return pens / students;
    }

    static int CalculateRemainingPens(int pens, int students) {
        // Calculate remaining pens using modulus operator
        return pens % students;
    }
}