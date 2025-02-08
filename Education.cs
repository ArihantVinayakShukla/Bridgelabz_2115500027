using System;

// Base class representing a Course
public class Course
{
    // Private fields for encapsulation
    private string courseName;
    private int duration;

    // Constructor to initialize course properties
    public Course(string courseName, int duration)
    {
        this.courseName = courseName;
        this.duration = duration;
    }

    // Public property for CourseName
    public string CourseName
    {
        get { return courseName; }
        set { courseName = value; }
    }

    // Public property for Duration
    public int Duration
    {
        get { return duration; }
        set { duration = value; }
    }

    // Virtual method to display course information
    public virtual string DisplayInfo()
    {
        return "Course: " + CourseName + ", Duration: " + Duration + " weeks";
    }
}

// OnlineCourse class inheriting from Course
public class OnlineCourse : Course
{
    // Private fields specific to OnlineCourse
    private string platform;
    private bool isRecorded;

    // Constructor calling base class constructor
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) 
        : base(courseName, duration)
    {
        this.platform = platform;
        this.isRecorded = isRecorded;
    }

    // Public property for Platform
    public string Platform
    {
        get { return platform; }
        set { platform = value; }
    }

    // Public property for IsRecorded
    public bool IsRecorded
    {
        get { return isRecorded; }
        set { isRecorded = value; }
    }

    // Override DisplayInfo to include online course information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", Platform: " + Platform + ", Recorded: " + IsRecorded;
    }
}

// PaidOnlineCourse class inheriting from OnlineCourse
public class PaidOnlineCourse : OnlineCourse
{
    // Private fields specific to PaidOnlineCourse
    private decimal fee;
    private decimal discount;

    // Constructor calling base class constructor
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, 
                           decimal fee, decimal discount) 
        : base(courseName, duration, platform, isRecorded)
    {
        this.fee = fee;
        this.discount = discount;
    }

    // Public property for Fee
    public decimal Fee
    {
        get { return fee; }
        set { fee = value; }
    }

    // Public property for Discount
    public decimal Discount
    {
        get { return discount; }
        set { discount = value; }
    }

    // Calculate final price after discount
    public decimal GetFinalPrice()
    {
        return Fee - (Fee * Discount / 100);
    }

    // Override DisplayInfo to include payment information
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + ", Fee: $" + Fee + ", Discount: " + Discount + "%, Final Price: $" + GetFinalPrice();
    }
}

// Main Program to demonstrate functionality
class Program
{
    static void Main(string[] args)
    {
        Course basicCourse = new Course("Programming Basics", 8);
        OnlineCourse onlineCourse = new OnlineCourse("Web Development", 12, "Udemy", true);
        PaidOnlineCourse paidCourse = new PaidOnlineCourse("Advanced AI", 16, "Coursera", true, 299.99m, 15);

        Console.WriteLine(basicCourse.DisplayInfo());
        Console.WriteLine(onlineCourse.DisplayInfo());
        Console.WriteLine(paidCourse.DisplayInfo());
    }
}