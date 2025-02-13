using System;

class InsertionSort
{
    // Method to sort employee IDs using Insertion Sort algorithm
    public static void SortEmployeeIDs(int[] ids)
    {
        // Get the number of elements in the array
        int n = ids.Length;
        
        // Iterate through the array starting from the second element
        for (int i = 1; i < n; i++)
        {
            // Store the current element to be compared
            int key = ids[i];
            // Initialize the previous index
            int j = i - 1;
            
            // Shift elements that are greater than key to one position ahead
            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }
            // Place the key at its correct position
            ids[j + 1] = key;
        }
    }

    static void Main(string[] args)
    {
        // Initialize an array of employee IDs
        int[] employeeIDs = { 1045, 1023, 1012, 1089, 1031 };
        
        // Display the original employee IDs
        Console.WriteLine("Original Employee IDs:");
        foreach (int id in employeeIDs)
        {
            Console.Write(id + " ");
        }
        
        // Call the sorting function to sort the employee IDs
        SortEmployeeIDs(employeeIDs);
        
        // Display the sorted employee IDs
        Console.WriteLine("\n\nSorted Employee IDs:");
        foreach (int id in employeeIDs)
        {
            Console.Write(id + " ");
        }
    }
}
