using System;

namespace EmployeeRecordsSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a regular employee
            Employee employee = new Employee("E001", "HR", 50000);
            employee.DisplayInfo();
            employee.GiveRaise(5000);

            // Create a manager
            Manager manager = new Manager("M001", "Sales", 80000, 10);
            manager.DisplayInfo();
            manager.GiveRaise(10000);
        }
    }

    public class Employee
    {
        // Public member - accessible from anywhere
        public string employeeID;
        
        // Protected member - accessible in this class and derived classes
        protected string department;
        
        // Private member - accessible only within this class
        private double salary;

        // Constructor
        public Employee(string employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        // Public method to get salary
        public double GetSalary()
        {
            return salary;
        }

        // Public method to give raise
        public virtual void GiveRaise(double amount)
        {
            if (amount > 0)
            {
                salary += amount;
                // Display salary increase message
                Console.WriteLine("Salary increased by $" + amount.ToString("F2") + ". New salary: $" + salary.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Invalid raise amount.");
            }
        }

        // Public method to display employee information
        public virtual void DisplayInfo()
        {
            Console.WriteLine("\nEmployee Information:");
            // Display employee ID
            Console.WriteLine("Employee ID: " + employeeID);
            // Display department
            Console.WriteLine("Department: " + department);
            // Display salary
            Console.WriteLine("Salary: $" + salary.ToString("F2"));
        }
    }

    // Derived class demonstrating protected member access
    public class Manager : Employee
    {
        private int teamSize;

        public Manager(string employeeID, string department, double salary, int teamSize)
            : base(employeeID, department, salary)
        {
            this.teamSize = teamSize;
        }

        // Method demonstrating access to protected department
        public string GetDepartment()
        {
            return department; 
        }

        // Override raise method to include bonus for managers
        public override void GiveRaise(double amount)
        {
            // Managers get 20% extra on their raises
            double managerBonus = amount * 0.2;
            base.GiveRaise(amount + managerBonus);
            // Display manager bonus amount
            Console.WriteLine("Manager bonus included: $" + managerBonus.ToString("F2"));
        }

        // Override display method to include team size
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            // Display team size
            Console.WriteLine("Team Size: " + teamSize);
        }
    }
}