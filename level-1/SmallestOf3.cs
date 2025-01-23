using System; 


class SmallestOf3
{
   
    static void Main(string[] args)
    {
        // Read the first integer input from the user and convert it to an integer
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        // Read the second integer input from the user and convert it to an integer
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        // Read the third integer input from the user and convert it to an integer
        int num3 = Convert.ToInt32(Console.ReadLine());

        // Call the `FindFirstSmallest` method to check if the first number is the smallest,
        // and print the result to the console
        Console.WriteLine(FindFirstSmallest(num1, num2, num3));
    }

    // Method to check if the first number is the smallest among the three numbers
    static string FindFirstSmallest(int num1, int num2, int num3)
    {
        // If `num1` is smaller than both `num2` and `num3`, it is the smallest
        if (num1 < num2 && num1 < num3)
        {
            return "Is the first number the smallest? Yes"; 
        }
        else
        {
            return "Is the first number the smallest? No"; 
        }
    }
}
