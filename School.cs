using System;

// Base class representing a Person
public abstract class Person
{
    // Private fields for encapsulation
    private string name;
    private int age;

    // Constructor to initialize person properties
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Public property for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Public property for Age
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Abstract method to be implemented by derived classes
    public abstract string DisplayRole();

    // Virtual method to display basic information
    public virtual string DisplayInfo()
    {
        return "Name: " + Name + ", Age: " + Age;
    }
}

// Teacher class inheriting from Person
public class Teacher : Person
{
    // Private field specific to Teacher
    private string subject;

    // Constructor calling base class constructor
    public Teacher(string name, int age, string subject) 
        : base(name, age)
    {
        this.subject = subject;
    }

    // Public property for Subject
    public string Subject
    {
        get { return subject; }
        set { subject = value; }
    }

    // Implementation of DisplayRole for Teacher
    public override string DisplayRole()
    {
        return "Role: Teacher, Subject: " + Subject;
    }

    // Override DisplayInfo to include teacher information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", " + DisplayRole();
    }
}

// Student class inheriting from Person
public class Student : Person
{
    // Private field specific to Student
    private int grade;

    // Constructor calling base class constructor
    public Student(string name, int age, int grade) 
        : base(name, age)
    {
        this.grade = grade;
    }

    // Public property for Grade
    public int Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    // Implementation of DisplayRole for Student
    public override string DisplayRole()
    {
        return "Role: Student, Grade: " + Grade;
    }

    // Override DisplayInfo to include student information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", " + DisplayRole();
    }
}

// Staff class inheriting from Person
public class Staff : Person
{
    // Private field specific to Staff
    private string department;

    // Constructor calling base class constructor
    public Staff(string name, int age, string department) 
        : base(name, age)
    {
        this.department = department;
    }

    // Public property for Department
    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    // Implementation of DisplayRole for Staff
    public override string DisplayRole()
    {
        return "Role: Staff, Department: " + Department;
    }

    // Override DisplayInfo to include staff information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", " + DisplayRole();
    }
}

// Main Program to demonstrate functionality
class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher("John Smith", 35, "Mathematics");
        Student student = new Student("Jane Doe", 15, 10);
        Staff staff = new Staff("Mike Johnson", 45, "Administration");

        Console.WriteLine(teacher.DisplayInfo());
        Console.WriteLine(student.DisplayInfo());
        Console.WriteLine(staff.DisplayInfo());
    }
}