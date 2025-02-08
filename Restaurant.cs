using System;

// Interface defining worker behaviors
public interface IWorker
{
    // Method to be implemented by classes
    string PerformDuties();
}

// Base class representing a Person
public abstract class Person
{
    // Private fields for encapsulation
    private string name;
    private string id;

    // Constructor to initialize person properties
    public Person(string name, string id)
    {
        this.name = name;
        this.id = id;
    }

    // Public property for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Public property for Id
    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    // Virtual method to display basic information
    public virtual string DisplayInfo()
    {
        return "Name: " + Name + ", ID: " + Id;
    }
}

// Chef class inheriting from Person and implementing IWorker
public class Chef : Person, IWorker
{
    // Private field specific to Chef
    private string speciality;

    // Constructor calling base class constructor
    public Chef(string name, string id, string speciality) 
        : base(name, id)
    {
        this.speciality = speciality;
    }

    // Public property for Speciality
    public string Speciality
    {
        get { return speciality; }
        set { speciality = value; }
    }

    // Implementation of IWorker interface method
    public string PerformDuties()
    {
        return "Preparing special dishes in " + Speciality + " cuisine";
    }

    // Override DisplayInfo to include chef information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", Role: Chef, Speciality: " + Speciality;
    }
}

// Waiter class inheriting from Person and implementing IWorker
public class Waiter : Person, IWorker
{
    // Private field specific to Waiter
    private string section;

    // Constructor calling base class constructor
    public Waiter(string name, string id, string section) 
        : base(name, id)
    {
        this.section = section;
    }

    // Public property for Section
    public string Section
    {
        get { return section; }
        set { section = value; }
    }

    // Implementation of IWorker interface method
    public string PerformDuties()
    {
        return "Serving customers in section " + Section;
    }

    // Override DisplayInfo to include waiter information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", Role: Waiter, Section: " + Section;
    }
}

// Main Program to demonstrate functionality
class Program
{
    static void Main(string[] args)
    {
        Chef chef = new Chef("Gordon Ramsay", "C001", "French Cuisine");
        Waiter waiter = new Waiter("James Smith", "W001", "Main Dining");

        Console.WriteLine(chef.DisplayInfo());
        Console.WriteLine("Duties: " + chef.PerformDuties());
        Console.WriteLine();
        Console.WriteLine(waiter.DisplayInfo());
        Console.WriteLine("Duties: " + waiter.PerformDuties());
    }
}