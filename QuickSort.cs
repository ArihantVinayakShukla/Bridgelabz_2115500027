using System;

class QuickSort
{
    // Method to perform Quick Sort on product prices
    public static void SortProductPrices(decimal[] prices, int low, int high)
    {
        // Check if low index is smaller than high index
        if (low < high)
        {
            // Partition the array and get the partition index
            int partitionIndex = Partition(prices, low, high);
            
            // Recursively sort the left half of the array
            SortProductPrices(prices, low, partitionIndex - 1);
            // Recursively sort the right half of the array
            SortProductPrices(prices, partitionIndex + 1, high);
        }
    }
    
    // Method to partition the array using the last element as pivot
    private static int Partition(decimal[] prices, int low, int high)
    {
        // Select the pivot element
        decimal pivot = prices[high];
        // Initialize index for the smaller element
        int i = low - 1;
        
        // Iterate through the array to rearrange elements
        for (int j = low; j < high; j++)
        {
            // Check if the current element is smaller than or equal to the pivot
            if (prices[j] <= pivot)
            {
                // Increment the index for smaller elements
                i++;
                // Swap the current element with the element at index i
                decimal temp = prices[i];
                prices[i] = prices[j];
                prices[j] = temp;
            }
        }
        
        // Swap the pivot element to its correct position
        decimal temp1 = prices[i + 1];
        prices[i + 1] = prices[high];
        prices[high] = temp1;
        
        // Return the partition index
        return i + 1;
    }

    static void Main(string[] args)
    {
        // Initialize an array of product prices
        decimal[] productPrices = { 99.99m, 49.99m, 149.99m, 29.99m, 79.99m };
        
        // Display the original product prices
        Console.WriteLine("Original Product Prices:");
        foreach (decimal price in productPrices)
        {
            Console.Write(price + " ");
        }
        
        // Call the sorting function to sort the product prices
        SortProductPrices(productPrices, 0, productPrices.Length - 1);
        
        // Display the sorted product prices
        Console.WriteLine("\n\nSorted Product Prices:");
        foreach (decimal price in productPrices)
        {
            Console.Write(price + " ");
        }
    }
}
