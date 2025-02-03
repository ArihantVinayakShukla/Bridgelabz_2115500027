using System;

class Book
{
    // Static variable shared across all instances
    public static string LibraryName = "Tu Delft Library";
    
    // Readonly variable to prevent modification after initialization
    public readonly string ISBN;
    public string Title;
    public string Author;

    // Constructor using 'this' to resolve ambiguity
    public Book(string Title, string Author, string ISBN)
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN; // Readonly, can only be assigned here
    }

    // Static method to display library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }

    // Method to display book details using 'is' operator
    public void DisplayDetails()
    {
        if (this is Book) // Redundant, but included as per requirement
        {
            Console.WriteLine("Book Title: " + Title);
            Console.WriteLine("Book Author: " + Author);
            Console.WriteLine("Book ISBN: " + ISBN);
        }
        else
        {
            Console.WriteLine("Invalid Book Instance");
        }
    }

    // Main Method
    static void Main(string[] args)
    {
        // Calling static method to display library name
        Book.DisplayLibraryName();

        // Creating book instances
        Book book1 = new Book("Godan", "Munshi Premchand", "978046256171");
        Book book2 = new Book("Poos ki Raat", "Munshi Premchand", "6429378633971");

        // Displaying book details
        book1.DisplayDetails();
        book2.DisplayDetails();
    }
}
