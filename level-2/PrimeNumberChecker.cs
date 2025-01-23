using System;

public class PrimeNumberChecker
{
    public static void CheckPrime(int number)
    {
        // Check if number is greater than 1
        if (number <= 1)
        {
            Console.WriteLine(number + " is not a prime number");
            return;
        }

        // Flag to track primality
        bool isPrime = true;

        // Check for divisibility
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        // Print result
        Console.WriteLine(number + (isPrime ? " is a prime number" : " is not a prime number"));
    }

    public static void Main()
    {
        // Get user input and check for prime
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        CheckPrime(inputNumber);
    }
}