using System;

class HeapSort
{
    // Method to sort salary demands using Heap Sort algorithm
    public static void SortSalaries(int[] salaries)
    {
        // Get the number of elements in the array
        int n = salaries.Length;
        
        // Build the max heap by rearranging the array
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }
        
        // Extract elements from the heap one by one
        for (int i = n - 1; i > 0; i--)
        {
            // Swap the root (maximum element) with the last element
            int temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;
            
            // Heapify the reduced heap to maintain the heap property
            Heapify(salaries, i, 0);
        }
    }
    
    // Method to maintain the heap property
    private static void Heapify(int[] salaries, int n, int i)
    {
        // Initialize the largest element as root
        int largest = i;
        // Calculate the left child index
        int left = 2 * i + 1;
        // Calculate the right child index
        int right = 2 * i + 2;
        
        // Check if the left child exists and is greater than the root
        if (left < n && salaries[left] > salaries[largest])
        {
            largest = left;
        }
        
        // Check if the right child exists and is greater than the largest so far
        if (right < n && salaries[right] > salaries[largest])
        {
            largest = right;
        }
        
        // If the largest element is not the root, swap and continue heapifying
        if (largest != i)
        {
            int temp = salaries[i];
            salaries[i] = salaries[largest];
            salaries[largest] = temp;
            
            // Recursively heapify the affected subtree
            Heapify(salaries, n, largest);
        }
    }

    static void Main(string[] args)
    {
        // Initialize an array of salary demands
        int[] salaries = { 75000, 60000, 85000, 65000, 95000 };
        
        // Display the original salary demands
        Console.WriteLine("Original Salary Demands:");
        foreach (int salary in salaries)
        {
            Console.Write(salary + " ");
        }
        
        // Call the sorting function to sort the salary demands
        SortSalaries(salaries);
        
        // Display the sorted salary demands
        Console.WriteLine("\n\nSorted Salary Demands:");
        foreach (int salary in salaries)
        {
            Console.Write(salary + " ");
        }
    }
}
