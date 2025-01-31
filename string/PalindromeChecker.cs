using System;

class PalindromeChecker
{
    static void Main(string[] args)
    {
        // Create instance of PalindromeProcessor
        PalindromeProcessor processor = new PalindromeProcessor();
        processor.CheckPalindrome();
    }
}

class PalindromeProcessor
{
    // Method to check if string is palindrome
    public void CheckPalindrome()
    {
        // Get string from user
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        // Convert to lowercase and remove spaces
        string processedString = inputString.ToLower().Replace(" ", "");

        bool isPalindrome = true;

        // Check characters from start and end
        for (int i = 0; i < processedString.Length / 2; i++)
        {
            if (processedString[i] != processedString[processedString.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        // Display result
        if (isPalindrome)
        {
            Console.WriteLine(inputString + " is a palindrome");
        }
        else
        {
            Console.WriteLine(inputString + " is not a palindrome");
        }
    }
}