using System;

// Define a class to store employee details
class EmployeeDetails{
	
	// Private fields to store employee information
	private string name;
	private int salary;
	private int id;

	// Constructor to initialize employee details
	public EmployeeDetails(string name, int salary, int id){
		this.name = name;
		this.salary = salary;
		this.id = id;
	}
	
	// Method to display employee details
	public void DisplayEmployeeDetails(){
		Console.WriteLine("Employee ID: " + id);
		Console.WriteLine("Employee name: " + name);
		Console.WriteLine("Employee salary: " + salary);
	}

	// Main method - Entry point of the program
	static void Main(string[] args){
		
		// Take employee details as input from the user
		Console.Write("Enter the employee id: ");
		int id = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the employee name: ");
		string name = Console.ReadLine();
		Console.Write("Enter the employee salary: ");
		int salary = Convert.ToInt32(Console.ReadLine());
	
		// Create an EmployeeDetails object and display details
		EmployeeDetails show = new EmployeeDetails(name, salary, id);
		show.DisplayEmployeeDetails();
	}
}