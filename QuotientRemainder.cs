using System;

class QuotientAndRemainder
{
    static void CalculateQuotientAndRemainder(int number1, int number2)
    {
        // Calculate quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        // Print the result
        Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + " of two numbers " + number1 + " and " + number2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        CalculateQuotientAndRemainder(number1, number2);
    }
}
