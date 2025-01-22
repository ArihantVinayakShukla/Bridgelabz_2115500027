using System;
class PurchaseCalculator {
    static void Main(string[] args) {
        // Get unit price from user
        Console.WriteLine("Enter the unit price:");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        
        // Get quantity from user
        Console.WriteLine("Enter the quantity:");
        int quantity = Convert.ToInt32(Console.ReadLine());
        
        // Calculate total purchase price
        double totalPrice = CalculateTotalPrice(unitPrice, quantity);
        
        // Print the total purchase price
        Console.WriteLine(string.Format("The total purchase price is INR {0:F2} if the quantity {1} and unit price is INR {2}", 
                                totalPrice, quantity, unitPrice));
    }

    static double CalculateTotalPrice(double unitPrice, int quantity) {
        // Calculate total price by multiplying unit price with quantity
        return unitPrice * quantity;
    }
}