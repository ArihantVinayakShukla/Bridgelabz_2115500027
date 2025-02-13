using System;

class CountingSort
{
    // Method to sort student ages using Counting Sort algorithm
    public static void SortStudentAges(int[] ages)
    {
        // Define the maximum possible age
        int max = 18; 
        // Define the minimum possible age
        int min = 10; 
        // Calculate the range of values
        int range = max - min + 1;
        
        // Create an array to store the count of each age
        int[] count = new int[range];
        // Create an output array to store sorted ages
        int[] output = new int[ages.Length];
        
        // Count the occurrences of each age in the input array
        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - min]++;
        }
        
        // Compute cumulative counts to determine the position of elements
        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }
        
        // Build the output array by placing elements at their correct positions
        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - min] - 1] = ages[i];
            count[ages[i] - min]--;
        }
        
        // Copy the sorted elements back into the original array
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }

    static void Main(string[] args)
    {
        // Initialize an array of student ages
        int[] studentAges = { 15, 13, 12, 14, 13, 16, 14, 15 };
        
        // Display the original student ages
        Console.WriteLine("Original Student Ages:");
        foreach (int age in studentAges)
        {
            Console.Write(age + " ");
        }
        
        // Call the sorting function to sort student ages
        SortStudentAges(studentAges);
        
        // Display the sorted student ages
        Console.WriteLine("\n\nSorted Student Ages:");
        foreach (int age in studentAges)
        {
            Console.Write(age + " ");
        }
    }
}
