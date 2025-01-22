using System;
class FeeCalculatorWithInput {
    static void Main(string[] args) {
        // Create variables to store user input
        Console.WriteLine("Enter the fee amount:");
        int fee = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the discount percentage:");
        int discountPercent = Convert.ToInt32(Console.ReadLine());
        
        // Calculate the discount amount
        int discountAmount = CalculateDiscount(fee, discountPercent);
        
        // Calculate the final discounted fee
        int finalFee = CalculateFinalFee(fee, discountAmount);
        
        // Print the discount amount and final fee
        Console.WriteLine(string.Format("The discount amount is INR {0} and final discounted fee is INR {1}", 
                                discountAmount, finalFee));
    }

    static int CalculateDiscount(int fee, int discountPercent) {
        // Calculate discount amount using the formula: (fee * discount percentage) / 100
        return (fee * discountPercent) / 100;
    }

    static int CalculateFinalFee(int fee, int discount) {
        // Calculate final fee by subtracting discount from original fee
        return fee - discount;
    }
}