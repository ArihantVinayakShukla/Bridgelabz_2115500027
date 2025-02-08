using System;

// Base class for all employees
public abstract class Employee
{
    // Private fields for encapsulation
    private string name;
    private int id;
    private double salary;

    // Constructor to initialize employee properties
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Public properties with getters and setters
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    // Virtual method for displaying employee details
    public virtual string DisplayDetails()
    {
        return "Name: " + Name + ", ID: " + Id + ", Salary: $" + Salary;
    }
}

// Manager class inheriting from Employee
public class Manager : Employee
{
    // Additional property specific to Manager
    private int teamSize;

    // Constructor calling base class constructor
    public Manager(string name, int id, double salary, int teamSize) 
        : base(name, id, salary)
    {
        this.teamSize = teamSize;
    }

    // Property for TeamSize
    public int TeamSize
    {
        get { return teamSize; }
        set { teamSize = value; }
    }

    // Override DisplayDetails to include Manager-specific information
    public override string DisplayDetails()
    {
        return base.DisplayDetails() + ", Team Size: " + TeamSize;
    }
}

// Developer class inheriting from Employee
public class Developer : Employee
{
    // Additional property specific to Developer
    private string programmingLanguage;

    // Constructor calling base class constructor
    public Developer(string name, int id, double salary, string programmingLanguage) 
        : base(name, id, salary)
    {
        this.programmingLanguage = programmingLanguage;
    }

    // Property for ProgrammingLanguage
    public string ProgrammingLanguage
    {
        get { return programmingLanguage; }
        set { programmingLanguage = value; }
    }

    // Override DisplayDetails to include Developer-specific information
    public override string DisplayDetails()
    {
        return base.DisplayDetails() + ", Programming Language: " + ProgrammingLanguage;
    }
}

// Intern class inheriting from Employee
public class Intern : Employee
{
    // Additional property specific to Intern
    private string internshipDuration;

    // Constructor calling base class constructor
    public Intern(string name, int id, double salary, string internshipDuration) 
        : base(name, id, salary)
    {
        this.internshipDuration = internshipDuration;
    }

    // Property for InternshipDuration
    public string InternshipDuration
    {
        get { return internshipDuration; }
        set { internshipDuration = value; }
    }

    // Override DisplayDetails to include Intern-specific information
    public override string DisplayDetails()
    {
        return base.DisplayDetails() + ", Internship Duration: " + InternshipDuration;
    }
}

// Main Program to demonstrate the functionality
class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[]
        {
            new Manager("John Doe", 1, 80000, 10),
            new Developer("Jane Smith", 2, 65000, "C#"),
            new Intern("Bob Wilson", 3, 30000, "6 months")
        };

        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp.DisplayDetails());
        }
    }
}