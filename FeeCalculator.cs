using System;
class FeeCalculator {
    static void Main(string[] args) {
        // Create variables for course fee and discount percentage
        int fee = 125000;
        int discountPercent = 10;

        // Calculate the discount amount using the CalculateDiscount method
        int discountAmount = CalculateDiscount(fee, discountPercent);

        // Calculate the final fee after applying discount
        int discountedFee = CalculateDiscountedFee(fee, discountAmount);

        // Print the discount amount and final discounted fee
        Console.WriteLine(string.Format("The discount amount is INR {0} and final discounted fee is INR {1}", 
                                discountAmount, discountedFee));
    }

    static int CalculateDiscount(int fee, int discountPercent) {
        // Calculate discount amount using formula: (fee * discount percentage) / 100
        return (fee * discountPercent) / 100;
    }

    static int CalculateDiscountedFee(int fee, int discount) {
        // Calculate final fee by subtracting discount from original fee
        return fee - discount;
    }
}