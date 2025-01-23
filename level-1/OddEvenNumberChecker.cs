using System;

public class OddEvenNumberChecker
{
    public static void PrintOddEvenNumbers(int number)
    {
        // Loop through numbers from 1 to input number
        for (int i = 1; i <= number; i++)
        {
            // Check and print odd or even
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is an even number");
            }
            else
            {
                Console.WriteLine(i + " is an odd number");
            }
        }
    }

    public static void Main()
    {
        Console.Write("Enter a positive number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        if (inputNumber > 0)
        {
            PrintOddEvenNumbers(inputNumber);
        }
        else
        {
            Console.WriteLine("Please enter a positive number.");
        }
    }
}