using System;

class PrimeChecker
{
    static void Main(string[] args)
    {
        // Create instance of PrimeProcessor
        PrimeProcessor processor = new PrimeProcessor();
        processor.CheckNumber();
    }
}

class PrimeProcessor 
{
    // Method to check if number is prime
    public void CheckNumber()
    {
        // Get number from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        // Check if number is less than 2
        if (number < 2)
        {
            isPrime = false;
        }
        else
        {
            // Check for factors from 2 to square root of number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        // Display result
        if (isPrime)
        {
            Console.WriteLine(number + " is a prime number");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number");
        }
    }
}