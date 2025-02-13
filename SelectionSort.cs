using System;

class SelectionSort
{
    // Method to sort exam scores using Selection Sort algorithm
    public static void SortExamScores(int[] scores)
    {
        // Get the number of elements in the array
        int n = scores.Length;
        
        // Outer loop to traverse the entire array
        for (int i = 0; i < n - 1; i++)
        {
            // Initialize the index of the minimum element
            int minIndex = i;
            
            // Inner loop to find the minimum element in the remaining unsorted part
            for (int j = i + 1; j < n; j++)
            {
                // Update minIndex if a smaller element is found
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }
            
            // Swap the found minimum element with the first element of the unsorted part
            int temp = scores[minIndex];
            scores[minIndex] = scores[i];
            scores[i] = temp;
        }
    }

    static void Main(string[] args)
    {
        // Initialize an array of exam scores
        int[] examScores = { 85, 92, 78, 95, 88, 82 };
        
        // Display the original exam scores
        Console.WriteLine("Original Exam Scores:");
        foreach (int score in examScores)
        {
            Console.Write(score + " ");
        }
        
        // Call the sorting function to sort the exam scores
        SortExamScores(examScores);
        
        // Display the sorted exam scores
        Console.WriteLine("\n\nSorted Exam Scores:");
        foreach (int score in examScores)
        {
            Console.Write(score + " ");
        }
    }
}
