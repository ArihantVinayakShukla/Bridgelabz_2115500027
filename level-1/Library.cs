using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a library book
            LibraryBook book = new LibraryBook("The Hobbit", "J.R.R. Tolkien", 29.99);

            // Display initial book status
            Console.WriteLine("Initial Book Status:");
            book.DisplayInfo();

            // Attempt to borrow the book
            Console.WriteLine("\nAttempting to borrow the book...");
            book.BorrowBook();

            // Display updated status
            Console.WriteLine("\nUpdated Book Status:");
            book.DisplayInfo();

            // Attempt to borrow again
            Console.WriteLine("\nAttempting to borrow again...");
            book.BorrowBook();
        }
    }

    public class LibraryBook
    {
        // Private fields for encapsulation
        private string title;
        private string author;
        private double price;
        private bool isAvailable;

        // Constructor
        public LibraryBook(string title, string author, double price)
        {
            // Assign provided values to fields
            this.title = title;
            this.author = author;
            this.price = price;
            this.isAvailable = true;
        }

        // Public properties with controlled access
        public string Title
        {
            // Get the book title
            get { return title; }
            // Private setter to prevent modification outside class
            private set { title = value; }
        }

        public string Author
        {
            // Get the book author
            get { return author; }
            // Private setter to prevent modification outside class
            private set { author = value; }
        }

        public double Price
        {
            // Get the book price
            get { return price; }
            // Private setter to prevent modification outside class
            private set { price = value; }
        }

        public bool IsAvailable
        {
            // Get the availability status
            get { return isAvailable; }
            // Private setter to prevent modification outside class
            private set { isAvailable = value; }
        }

        // Method to borrow book
        public void BorrowBook()
        {
            if (isAvailable)
            {
                // Mark book as borrowed
                isAvailable = false;
                Console.WriteLine("Book successfully borrowed!");
            }
            else
            {
                Console.WriteLine("Sorry, this book is currently unavailable.");
            }
        }

        // Method to return book
        public void ReturnBook()
        {
            if (!isAvailable)
            {
                // Mark book as available
                isAvailable = true;
                Console.WriteLine("Book successfully returned!");
            }
            else
            {
                Console.WriteLine("Error: This book is already in the library.");
            }
        }

        // Method to display book information
        public void DisplayInfo()
        {
            // Print book details using string concatenation
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: $" + price.ToString("F2"));
            Console.WriteLine("Availability Status: " + (isAvailable ? "Available" : "Borrowed"));
        }
    }
}
