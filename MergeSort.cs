using System;

class MergeSort
{
    // Method to perform Merge Sort on book prices
    public static void SortBookPrices(double[] prices, int left, int right)
    {
        // Check if left index is smaller than right index
        if (left < right)
        {
            // Find the middle index
            int middle = (left + right) / 2;
            
            // Recursively sort the left half of the array
            SortBookPrices(prices, left, middle);
            // Recursively sort the right half of the array
            SortBookPrices(prices, middle + 1, right);
            
            // Merge the sorted halves
            Merge(prices, left, middle, right);
        }
    }
    
    // Method to merge two sorted halves of the array
    private static void Merge(double[] prices, int left, int middle, int right)
    {
        // Determine the sizes of the temporary arrays
        int n1 = middle - left + 1;
        int n2 = right - middle;
        
        // Create temporary arrays to store the left and right halves
        double[] leftArray = new double[n1];
        double[] rightArray = new double[n2];
        
        // Copy data to left temporary array
        for (int i = 0; i < n1; i++)
        {
            leftArray[i] = prices[left + i];
        }
        // Copy data to right temporary array
        for (int j = 0; j < n2; j++)
        {
            rightArray[j] = prices[middle + 1 + j];
        }
        
        // Initialize indices for merging process
        int k = left;
        int leftIndex = 0;
        int rightIndex = 0;
        
        // Merge elements from left and right arrays into the main array
        while (leftIndex < n1 && rightIndex < n2)
        {
            // Compare elements and insert the smaller one into the main array
            if (leftArray[leftIndex] <= rightArray[rightIndex])
            {
                prices[k] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                prices[k] = rightArray[rightIndex];
                rightIndex++;
            }
            k++;
        }
        
        // Copy any remaining elements from the left array
        while (leftIndex < n1)
        {
            prices[k] = leftArray[leftIndex];
            leftIndex++;
            k++;
        }
        
        // Copy any remaining elements from the right array
        while (rightIndex < n2)
        {
            prices[k] = rightArray[rightIndex];
            rightIndex++;
            k++;
        }
    }

    static void Main(string[] args)
    {
        // Initialize an array of book prices
        double[] bookPrices = { 29.99, 15.99, 42.99, 12.99, 35.99 };
        
        // Display the original book prices
        Console.WriteLine("Original Book Prices:");
        foreach (double price in bookPrices)
        {
            Console.Write(price + " ");
        }
        
        // Call the sorting function to sort the book prices
        SortBookPrices(bookPrices, 0, bookPrices.Length - 1);
        
        // Display the sorted book prices
        Console.WriteLine("\n\nSorted Book Prices:");
        foreach (double price in bookPrices)
        {
            Console.Write(price + " ");
        }
    }
}
