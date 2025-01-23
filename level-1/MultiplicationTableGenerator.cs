using System;

public class MultiplicationTableGenerator
{
    public static void GenerateMultiplicationTable(int number)
    {
        // Generate multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            int result = number * i;
            Console.WriteLine(number + " * " + i + " = " + result);
        }
    }

    public static void Main()
    {
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        GenerateMultiplicationTable(inputNumber);
    }
}