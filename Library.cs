using System;

// Base class representing a Book
public class Book
{
    // Private fields for encapsulation
    private string title;
    private int publicationYear;

    // Constructor to initialize book properties
    public Book(string title, int publicationYear)
    {
        this.title = title;
        this.publicationYear = publicationYear;
    }

    // Public property for Title
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    // Public property for PublicationYear
    public int PublicationYear
    {
        get { return publicationYear; }
        set { publicationYear = value; }
    }

    // Virtual method to display book information
    public virtual string DisplayInfo()
    {
        return "Title: " + Title + ", Publication Year: " + PublicationYear;
    }
}

// Author class inheriting from Book
public class Author : Book
{
    // Private fields specific to Author
    private string name;
    private string bio;

    // Constructor calling base class constructor
    public Author(string title, int publicationYear, string name, string bio) 
        : base(title, publicationYear)
    {
        this.name = name;
        this.bio = bio;
    }

    // Public property for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Public property for Bio
    public string Bio
    {
        get { return bio; }
        set { bio = value; }
    }

    // Override DisplayInfo to include author information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", Author: " + Name + ", Bio: " + Bio;
    }
}

// Main Program to demonstrate functionality
class Program
{
    static void Main(string[] args)
    {
        Author author = new Author("The Great Gatsby", 1925, "F. Scott Fitzgerald", "American novelist");
        Console.WriteLine(author.DisplayInfo());
    }
}