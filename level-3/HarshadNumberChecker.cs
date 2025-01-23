using System;

public class HarshadNumberChecker
{
    public static void CheckHarshadNumber(int number)
    {
        // Initialize sum and store the original number
        int sum = 0, originalNumber = number;

        // Calculate the sum of digits
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        // Check if the original number is divisible by the sum of digits
        Console.WriteLine(originalNumber % sum == 0 ? "Harshad Number" : "Not a Harshad Number");
    }

    public static void Main()
    {
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        CheckHarshadNumber(inputNumber);
    }
}