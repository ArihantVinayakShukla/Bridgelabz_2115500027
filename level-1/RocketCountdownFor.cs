using System;

public class RocketCountdownFor
{
    public static void PerformCountdown(int startValue)
    {
        // Countdown loop using for
        for (int counter = startValue; counter >= 1; counter--)
        {
            Console.WriteLine(counter);
        }

        Console.WriteLine("Liftoff!");
    }

    public static void Main()
    {
        // Get user input for countdown
        Console.Write("Enter countdown start value: ");
        int countdownStart = Convert.ToInt32(Console.ReadLine());

        // Perform countdown
        PerformCountdown(countdownStart);
    }
}