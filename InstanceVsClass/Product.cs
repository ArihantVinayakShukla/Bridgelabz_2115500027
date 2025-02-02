using System;

namespace ProductInventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create multiple products
            Product laptop = new Product("Laptop", 999.99);
            Product phone = new Product("Smartphone", 599.99);
            Product tablet = new Product("Tablet", 299.99);

            // Display individual product details
            Console.WriteLine("Individual Product Details:");
            laptop.DisplayProductDetails();
            phone.DisplayProductDetails();
            tablet.DisplayProductDetails();

            // Display total products count
            Console.WriteLine("\nTotal Products Information:");
            Product.DisplayTotalProducts();
        }
    }

    public class Product
    {
        // Instance variables
        private string productName;
        private double price;

        // Static variable (class variable)
        private static int totalProducts = 0;

        // Constructor
        public Product(string productName, double price)
        {
            // Assign product name
            this.productName = productName;
            // Assign product price
            this.price = price;
            // Increment total products when new product is created
            totalProducts++;
        }

        // Public properties
        public string ProductName
        {
            get { return productName; }
            private set { productName = value; }
        }

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        // Instance method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine("\nProduct Details:");
            Console.WriteLine("Name: " + productName);
            Console.WriteLine("Price: $" + price.ToString("F2"));
        }

        // Static method to display total products
        public static void DisplayTotalProducts()
        {
            Console.WriteLine("Total number of products in inventory: " + totalProducts);
        }
    }
}
