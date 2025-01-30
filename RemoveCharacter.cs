using System;

class RemoveCharacter
{
    // Method to remove a specific character from string
    public static string RemoveCharacters(string inputString, char charToRemove)
    {
        // Create a character array to store result
        char[] result = new char[inputString.Length];
        int newIndex = 0;
        
        // Copy characters except the one to remove
        for (int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] != charToRemove)
            {
                result[newIndex] = inputString[i];
                newIndex++;
            }
        }
        
        // Convert result array back to string
        string outputString = "";
        for (int i = 0; i < newIndex; i++)
        {
            outputString += result[i];
        }
        
        return outputString;
    }
    
    static void Main(string[] args)
    {
        // Get input string from user
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();
        
        // Get character to remove
        Console.Write("Enter character to remove: ");
        char charToRemove = Console.ReadLine()[0];
        
        // Remove character and display result
        string modifiedString = RemoveCharacters(inputString, charToRemove);
        
        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Original String: " + inputString);
        Console.WriteLine("Character Removed: " + charToRemove);
        Console.WriteLine("Modified String: " + modifiedString);
    }
}