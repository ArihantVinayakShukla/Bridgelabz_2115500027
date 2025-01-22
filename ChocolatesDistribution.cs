using System;

class ChocolatesDistribution
{
    // Method to distribute chocolates and calculate remaining chocolates
    static void DistributeChocolates(int chocolates, int children)
    {
        // Calculate chocolates per child
        int chocolatesPerChild = chocolates / children;

        // Calculate remaining chocolates
        int remainingChocolates = chocolates % children;

        // Print the results
        Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild + " and the number of remaining chocolates is " + remainingChocolates);
    }

    // Main method to take inputs and call the distribution method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the total number of chocolates:");
        int chocolates = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of children:");
        int children = int.Parse(Console.ReadLine()); 

        // Call the method to distribute chocolates
        DistributeChocolates(chocolates, children);
    }
}
