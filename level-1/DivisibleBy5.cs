using System;

class DivisibleBy5
{
    // Prompts the user to input a number and calls the CalculateDivisibility method
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it's divisible by 5:");
        string num = Console.ReadLine();
        CalculateDivisibility(num); 
    }

    // CalculateDivisibility method: Checks if the input number is divisible by 5
    static void CalculateDivisibility(string num)
    {
        int number; 

        // Tries to parse the input string into an integer
        if (int.TryParse(num, out number)) 
        {
            // Checks if the number is divisible by 5 and prepares the result message
            string result = number % 5 == 0 
                ? $"Is the number {number} divisible by 5? Yes" 
                : $"Is the number {number} divisible by 5? No";
            Console.WriteLine(result);
        }
        else
        {
            // Informs the user if the input is invalid
            Console.WriteLine("Invalid Input. Please enter a valid integer.");
        }
    }
}
