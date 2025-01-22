using System;
class ProfitCalculator {
    static void Main(string[] args) {
        // Create variables for cost price and selling price in INR
        int costPrice = 129;
        int sellingPrice = 191;

        // Calculate the profit using the CalculateProfit method
        int profit = CalculateProfit(costPrice, sellingPrice);

        // Calculate the profit percentage using the CalculateProfitPercentage method
        double profitPercentage = CalculateProfitPercentage(profit, costPrice);

        // Print the cost price, selling price, profit and profit percentage
        Console.WriteLine(string.Format("The Cost Price is INR {0} and Selling Price is INR {1}\n" +
                                "The Profit is INR {2} and the Profit Percentage is {3:F2}%", 
                                costPrice, sellingPrice, profit, profitPercentage));
    }

    static int CalculateProfit(int costPrice, int sellingPrice) {
        // Calculate profit by subtracting cost price from selling price
        return sellingPrice - costPrice;
    }

    static double CalculateProfitPercentage(int profit, int costPrice) {
        // Calculate profit percentage using formula: (profit/cost price) * 100
        return (profit / (double)costPrice) * 100;
    }
}