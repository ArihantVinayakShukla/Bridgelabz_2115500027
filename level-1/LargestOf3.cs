using System;

class LargestOf3
{
    static void Main(string[] args)
    {
        // Read three integer inputs from the user and convert them to integers
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        // Call the `FindLargest` method and print the result
        Console.WriteLine(FindLargest(num1, num2, num3));
    }

    // Method to determine which number is the largest among the three inputs
    static string FindLargest(int num1, int num2, int num3)
    {
        // Base output template for all cases
        string template = "Is the first number the largest? {0}\n"
                        + "Is the second number the largest? {1}\n"
                        + "Is the third number the largest? {2}";

        // Determine the largest number and return the corresponding formatted string
        if (num1 > num2 && num1 > num3)
        {
            return string.Format(template, "Yes", "No", "No");
        }
        else if (num2 > num1 && num2 > num3)
        {
            return string.Format(template, "No", "Yes", "No");
        }
        else
        {
            return string.Format(template, "No", "No", "Yes");
        }
    }
}
