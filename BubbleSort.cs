using System;

class BubbleSort
{
    // Method to sort student marks using Bubble Sort algorithm
    public static void SortStudentMarks(int[] marks)
    {
        // Get the number of elements in the array
        int n = marks.Length;
        
        // Outer loop to traverse the entire array
        for (int i = 0; i < n - 1; i++)
        {
            // Inner loop to compare adjacent elements and swap if necessary
            for (int j = 0; j < n - i - 1; j++)
            {
                // Check if the current element is greater than the next element
                if (marks[j] > marks[j + 1])
                {
                    // Swap the elements to arrange them in ascending order
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        // Initialize an array of student marks
        int[] studentMarks = { 78, 55, 45, 98, 83, 65, 91 };
        
        // Display the original student marks
        Console.WriteLine("Original Student Marks:");
        foreach (int mark in studentMarks)
        {
            Console.Write(mark + " ");
        }
        
        // Call the sorting function to sort the student marks
        SortStudentMarks(studentMarks);
        
        // Display the sorted student marks
        Console.WriteLine("\n\nSorted Student Marks:");
        foreach (int mark in studentMarks)
        {
            Console.Write(mark + " ");
        }
    }
}
