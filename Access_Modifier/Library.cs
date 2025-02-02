using System;

namespace BookLibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a regular book
            Book book = new Book("978-0-123456-78-9", "The Great Novel", "John Author");
            book.DisplayInfo();

            // Create an ebook
            EBook ebook = new EBook("978-0-987654-32-1", "Digital World", "Jane Writer", "PDF");
            ebook.DisplayInfo();
        }
    }

    public class Book
    {
        // Public member - accessible from anywhere
        public string ISBN;
        
        // Protected member - accessible in this class and derived classes
        protected string title;
        
        // Private member - accessible only within this class
        private string author;

        // Constructor
        public Book(string isbn, string title, string author)
        {
            this.ISBN = isbn;
            this.title = title;
            this.author = author;
        }

        // Public methods to access private author field
        public string GetAuthor()
        {
            return author;
        }

        public void SetAuthor(string newAuthor)
        {
            if (!string.IsNullOrEmpty(newAuthor))
            {
                author = newAuthor;
                Console.WriteLine("Author updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid author name provided.");
            }
        }

        // Public method to display book information
        public virtual void DisplayInfo()
        {
            Console.WriteLine("\nBook Information:");
            
            // Replaced string interpolation with concatenation
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
        }
    }

    // Derived class demonstrating protected member access
    public class EBook : Book
    {
        private string format;

        public EBook(string isbn, string title, string author, string format)
            : base(isbn, title, author)
        {
            this.format = format;
        }

        // Method demonstrating access to protected title
        public string GetBookTitle()
        {
            return title; 
        }

        // Override display method to include format
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            
            // Replaced string interpolation with concatenation
            Console.WriteLine("Format: " + format);
        }
    }
}
