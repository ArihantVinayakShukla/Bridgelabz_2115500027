using System;

namespace PersonManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create original person
            Person original = new Person("John Doe", 30, "123 Main St");
            
            // Create copy using copy constructor
            Person copy = new Person(original);

            // Display both persons
            Console.WriteLine("Original Person:");
            original.DisplayInfo();

            Console.WriteLine("\nCopied Person:");
            copy.DisplayInfo();
        }
    }

    public class Person
    {
        // Private fields for encapsulation
        private string name;
        private int age;
        private string address;

        // Parameterized constructor
        public Person(string name, int age, string address)
        {
            // Assign provided values to fields
            this.name = name;
            this.age = age;
            this.address = address;
        }

        // Copy constructor
        public Person(Person other)
        {
            // Copy values from another Person object
            this.name = other.name;
            this.age = other.age;
            this.address = other.address;
        }

        // Public properties with controlled access
        public string Name
        {
            // Get the name
            get { return name; }
            // Private setter to prevent modification outside class
            private set { name = value; }
        }

        public int Age
        {
            // Get the age
            get { return age; }
            // Private setter to prevent modification outside class
            private set { age = value; }
        }

        public string Address
        {
            // Get the address
            get { return address; }
            // Private setter to prevent modification outside class
            private set { address = value; }
        }

        // Method to display person information
        public void DisplayInfo()
        {
            // Print person details using string concatenation
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
        }
    }
}
