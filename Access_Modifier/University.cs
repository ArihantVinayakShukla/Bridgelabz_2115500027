using System;

namespace UniversityManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a regular student
            Student student = new Student("S001", "John Smith", 3.5);
            student.DisplayInfo();

            // Create a postgraduate student
            PostgraduateStudent pgStudent = new PostgraduateStudent("P001", "Jane Doe", 3.8, "Computer Science");
            pgStudent.DisplayInfo();
        }
    }

    public class Student
    {
        // Public member - accessible from anywhere
        public string rollNumber;
        
        // Protected member - accessible in this class and derived classes
        protected string name;
        
        // Private member - accessible only within this class
        private double cgpa;

        // Constructor
        public Student(string rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;
        }

        // Public method to get CGPA
        public double GetCGPA()
        {
            return cgpa;
        }

        // Public method to set CGPA with validation
        public void SetCGPA(double newCGPA)
        {
            if (newCGPA >= 0 && newCGPA <= 4.0)
            {
                cgpa = newCGPA;
                Console.WriteLine("CGPA updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid CGPA value. Must be between 0 and 4.0");
            }
        }

        // Public method to display student information
        public virtual void DisplayInfo()
        {
            Console.WriteLine("\nStudent Information:");
            
            // Replaced string interpolation with concatenation
            Console.WriteLine("Roll Number: " + rollNumber);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("CGPA: " + cgpa.ToString("F2"));
        }
    }

    // Derived class demonstrating protected member access
    public class PostgraduateStudent : Student
    {
        private string specialization;

        public PostgraduateStudent(string rollNumber, string name, double cgpa, string specialization)
            : base(rollNumber, name, cgpa)
        {
            this.specialization = specialization;
        }

        // Method demonstrating access to protected member
        public string GetStudentName()
        {
            return name; // Can access protected member
        }

        // Override display method to include specialization
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            
            // Replaced string interpolation with concatenation
            Console.WriteLine("Specialization: " + specialization);
        }
    }
}