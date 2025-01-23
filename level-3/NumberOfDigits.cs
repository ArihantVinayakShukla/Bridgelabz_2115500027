using System;

public class NumberOfDigits
{
    public static void CountDigits(int number)
    {
        // Initialize a counter variable
        int count = 0;

        // Iterate through digits, incrementing the counter
        while (number != 0)
        {
            number /= 10;
            count++;
        }

        Console.WriteLine("Number of digits: " + count);
    }

    public static void Main()
    {
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        CountDigits(inputNumber);
    }
}