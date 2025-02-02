using System;

namespace CourseManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create multiple courses
            Course programming = new Course("Programming Fundamentals", 3, 299.99);
            Course webDev = new Course("Web Development", 4, 399.99);
            Course database = new Course("Database Management", 2, 249.99);

            // Display initial course details
            Console.WriteLine("Initial Course Details:");
            programming.DisplayCourseDetails();
            webDev.DisplayCourseDetails();
            database.DisplayCourseDetails();

            // Update institute name
            Console.WriteLine("\nUpdating Institute Name...");
            Course.UpdateInstituteName("Tech Academy Pro");

            // Display updated course details
            Console.WriteLine("\nUpdated Course Details:");
            programming.DisplayCourseDetails();
            webDev.DisplayCourseDetails();
            database.DisplayCourseDetails();
        }
    }

    public class Course
    {
        // Instance variables
        private string courseName;
        private int duration;
        private double fee;

        // Static variable (class variable)
        private static string instituteName = "Tech Academy";

        // Constructor
        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        // Public properties
        public string CourseName
        {
            get { return courseName; }
            private set { courseName = value; }
        }

        public int Duration
        {
            get { return duration; }
            private set { duration = value; }
        }

        public double Fee
        {
            get { return fee; }
            private set { fee = value; }
        }

        // Instance method to display course details
        public void DisplayCourseDetails()
        {
            Console.WriteLine("\nCourse Details:");
            Console.WriteLine("Institute: " + instituteName);
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Duration: " + duration + " months");
            Console.WriteLine("Fee: $" + fee.ToString("F2"));
        }

        // Static method to update institute name
        public static void UpdateInstituteName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                instituteName = newName;
                Console.WriteLine("Institute name updated to: " + instituteName);
            }
            else
            {
                Console.WriteLine("Invalid institute name provided.");
            }
        }
    }
}
