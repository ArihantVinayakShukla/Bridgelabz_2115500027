using System;

public class BMICalculator
{
    public static void CalculateBMI()
    {
        // Prompt user to input the number of persons
        Console.Write("Enter number of persons: ");
        int personCount = Convert.ToInt32(Console.ReadLine());

        // Create a 2D array to store weight, height, and BMI for each person
        double[,] personData = new double[personCount, 3];

        // Create an array to store the weight status of each person
        string[] weightStatus = new string[personCount];

        // Loop through each person to collect their data
        for (int i = 0; i < personCount; i++)
        {
            // Prompt and validate weight input
            while (true)
            {
                Console.Write($"Enter weight for person {i + 1} (kg): ");
                double weight = Convert.ToDouble(Console.ReadLine());
                if (weight > 0)
                {
                    personData[i, 0] = weight; // Store weight in the array
                    break;
                }
                Console.WriteLine("Weight must be positive. Try again.");
            }

            // Prompt and validate height input
            while (true)
            {
                Console.Write($"Enter height for person {i + 1} (m): ");
                double height = Convert.ToDouble(Console.ReadLine());
                if (height > 0)
                {
                    personData[i, 1] = height; // Store height in the array
                    break;
                }
                Console.WriteLine("Height must be positive. Try again.");
            }

            // Calculate BMI using the formula: weight / (height * height)
            double bmi = personData[i, 0] / (personData[i, 1] * personData[i, 1]);
            personData[i, 2] = bmi; // Store BMI in the array

            // Determine the weight status based on BMI
            if (bmi < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                weightStatus[i] = "Normal";
            else if (bmi >= 25 && bmi < 30)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        // Display BMI results for each person
        Console.WriteLine("\nBMI Results:");
        for (int i = 0; i < personCount; i++)
        {
            Console.WriteLine($"Person {i + 1}:");
            Console.WriteLine($"Weight: {personData[i, 0]} kg");
            Console.WriteLine($"Height: {personData[i, 1]} m");
            Console.WriteLine($"BMI: {Math.Round(personData[i, 2], 2)}");
            Console.WriteLine($"Status: {weightStatus[i]}");
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        // Call the BMI calculation method
        CalculateBMI();
    }
}
