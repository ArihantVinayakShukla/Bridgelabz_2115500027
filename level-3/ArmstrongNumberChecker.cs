using System;

public class ArmstrongNumberChecker
{
    public static void CheckArmstrongNumber(int number)
    {
        // Store the original number and initialize sum to 0
        int originalNumber = number, sum = 0;

        // Iterate through digits, adding cubes to the sum
        while (number != 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, 3);
            number /= 10;
        }

        // Check if the original number matches the sum of cubes
        Console.WriteLine(sum == originalNumber ? "Armstrong Number" : "Not an Armstrong Number");
    }

    public static void Main()
    {
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        CheckArmstrongNumber(inputNumber);
    }
}