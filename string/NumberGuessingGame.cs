using System;

class NumberGuessingGame
{
    // Variables to store game boundaries
    private static int minNumber = 1;
    private static int maxNumber = 100;
    
    // Main entry point of the program
    static void Main(string[] args)
    {
        GameLogic gameLogic = new GameLogic();
        gameLogic.StartGame();
    }
}

class GameLogic
{
    // Random number generator instance
    private Random random;

    // Constructor to initialize random number generator
    public GameLogic()
    {
        random = new Random();
    }

    // Method to start and control the game flow
    public void StartGame()
    {
        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("After each guess, enter: 'H' for too high, 'L' for too low, 'C' for correct");
        
        // Variables to track game progress
        bool isGameOver = false;
        int minGuess = 1;
        int maxGuess = 100;
        
        while (!isGameOver)
        {
            // Generate and display computer's guess using Random
            int computerGuess = random.Next(minGuess, maxGuess + 1);
            Console.WriteLine("Computer's guess: " + computerGuess);
            
            // Get and process user feedback
            string userFeedback = GetUserFeedback();
            
            // Update game state based on feedback
            if (userFeedback.ToUpper() == "H")
            {
                maxGuess = computerGuess - 1;
            }
            else if (userFeedback.ToUpper() == "L")
            {
                minGuess = computerGuess + 1;
            }
            else if (userFeedback.ToUpper() == "C")
            {
                Console.WriteLine("Computer guessed your number!");
                isGameOver = true;
            }
            
            // Check if the range is invalid
            if (minGuess > maxGuess)
            {
                Console.WriteLine("Invalid input sequence. Please play again.");
                isGameOver = true;
            }
        }
    }
    
    // Method to get and validate user feedback
    private string GetUserFeedback()
    {
        string feedback;
        do
        {
            Console.Write("Enter your feedback (H/L/C): ");
            feedback = Console.ReadLine().ToUpper();
        } while (feedback != "H" && feedback != "L" && feedback != "C");
        
        return feedback;
    }
}