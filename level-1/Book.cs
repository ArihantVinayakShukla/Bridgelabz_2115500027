using System;

namespace BookManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create books using different constructors
            Book defaultBook = new Book();
            Book customBook = new Book("The Great Gatsby", "F. Scott Fitzgerald", 19.99);

            // Display book information
            Console.WriteLine("Default Book:");
            defaultBook.DisplayInfo();

            Console.WriteLine("\nCustom Book:");
            customBook.DisplayInfo();
        }
    }

    public class Book
    {
        // Private fields for encapsulation
        private string title;
        private string author;
        private double price;

        // Default constructor
        public Book()
        {
            // Assign default values
            this.title = "Unknown";
            this.author = "Unknown";
            this.price = 0.0;
        }

        // Parameterized constructor
        public Book(string title, string author, double price)
        {
            // Assign provided values to fields
            this.title = title;
            this.author = author;
            this.price = price;
        }

        // Public properties with controlled access
        public string Title
        {
            // Get the title
            get { return title; }
            // Private setter to prevent modification outside class
            private set { title = value; }
        }

        public string Author
        {
            // Get the author
            get { return author; }
            // Private setter to prevent modification outside class
            private set { author = value; }
        }

        public double Price
        {
            // Get the price
            get { return price; }
            // Private setter to prevent modification outside class
            private set { price = value; }
        }

        // Method to display book information
        public void DisplayInfo()
        {
            // Print book details using string concatenation
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: $" + price.ToString("F2"));
        }
    }
}
