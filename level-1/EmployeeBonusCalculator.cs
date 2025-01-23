using System;

public class EmployeeBonusCalculator
{
    public static void CalculateBonus(double salary, int yearsOfService)
    {
        // Check if employee qualifies for bonus
        if (yearsOfService > 5)
        {
            double bonusPercentage = 0.05; // 5% bonus
            double bonusAmount = salary * bonusPercentage;

            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Years of Service: " + yearsOfService);
            Console.WriteLine("Bonus Amount: " + bonusAmount);
        }
        else
        {
            Console.WriteLine("No bonus for employees with less than 5 years of service.");
        }
    }

    public static void Main()
    {
        Console.Write("Enter salary: ");
        double employeeSalary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter years of service: ");
        int serviceYears = Convert.ToInt32(Console.ReadLine());

        CalculateBonus(employeeSalary, serviceYears);
    }
}