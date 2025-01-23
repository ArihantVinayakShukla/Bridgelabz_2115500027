using System;

public class MarksGradeCalculator
{
    // Function to calculate grade and remarks based on average marks
    public static void CalculateGrade(double physics, double chemistry, double maths)
    {
        // Calculate total marks and average mark
        double totalMarks = physics + chemistry + maths;
        double averageMark = totalMarks / 3;

        string grade;
        string remarks;

        // Assign grade and remarks based on average mark
        if (averageMark >= 90) { grade = "A+"; remarks = "Excellent Performance"; }
        else if (averageMark >= 80) { grade = "A"; remarks = "Very Good Performance"; }
        else if (averageMark >= 70) { grade = "B"; remarks = "Good Performance"; }
        else if (averageMark >= 60) { grade = "C"; remarks = "Satisfactory Performance"; }
        else if (averageMark >= 50) { grade = "D"; remarks = "Needs Improvement"; }
        else { grade = "F"; remarks = "Poor Performance"; }

        // Display results
        Console.WriteLine("Physics Marks: " + physics);
        Console.WriteLine("Chemistry Marks: " + chemistry);
        Console.WriteLine("Maths Marks: " + maths);
        Console.WriteLine("Average Mark: " + averageMark);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Remarks: " + remarks);
    }

    public static void Main()
    {
        // Get user input for marks
        Console.Write("Enter Physics Marks: "); double physicsMark = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Chemistry Marks: "); double chemistryMark = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Maths Marks: "); double mathsMark = Convert.ToDouble(Console.ReadLine());
        CalculateGrade(physicsMark, chemistryMark, mathsMark);
    }
}