using System;

// Define a class to represent a book
class Book
{
    // Private fields to store book details
    private string title;
    private string author;
    private double price;

    // Constructor to initialize book details
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("\nBook Details:");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: $" + price);
    }

    // Main method - Entry point of the program
    static void Main(string[] args)
    {
        // Take book details as input from the user
        Console.Write("Enter the book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the book author: ");
        string author = Console.ReadLine();

        Console.Write("Enter the book price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        // Create a Book object and display details
        Book book = new Book(title, author, price);
        book.DisplayBookDetails();
    }
}