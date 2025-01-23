using System;

public class FriendsDetails
{
    public static void FindYoungestAndTallest(int amarAge, int akarAge, int anthonyAge, double amarHeight, double akarHeight, double anthonyHeight)
    {
        // Find the youngest friend
        int youngestAge = Math.Min(amarAge, Math.Min(akarAge, anthonyAge));
        string youngestFriend = "";
        if (amarAge == youngestAge)
            youngestFriend = "Amar";
        else if (akarAge == youngestAge)
            youngestFriend = "Akbar";
        else
            youngestFriend = "Anthony";

        // Find the tallest friend
        double tallestHeight = Math.Max(amarHeight, Math.Max(akarHeight, anthonyHeight));
        string tallestFriend = "";
        if (amarHeight == tallestHeight)
            tallestFriend = "Amar";
        else if (akarHeight == tallestHeight)
            tallestFriend = "Akbar";
        else
            tallestFriend = "Anthony";

        // Output the results
        Console.WriteLine("Youngest Friend: " + youngestFriend);
        Console.WriteLine("Tallest Friend: " + tallestFriend);
    }

    public static void Main()
    {
        // Get user input for ages and heights of the three friends
        Console.Write("Enter Amar's age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int akarAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Amar's height (cm): ");
        double amarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Akbar's height (cm): ");
        double akarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Anthony's height (cm): ");
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());

        // Call the FindYoungestAndTallest method to compute and display the results
        FindYoungestAndTallest(amarAge, akarAge, anthonyAge, amarHeight, akarHeight, anthonyHeight);
    }
}