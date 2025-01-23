using System;

public class RocketCountdownWhile
{
    public static void PerformCountdown(int startValue)
    {
        // Initialize counter with user input
        int counter = startValue;

        // Countdown loop
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
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