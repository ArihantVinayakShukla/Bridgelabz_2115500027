using System;

class Toggle
{
    static void Main()
    {
        // Prompt the user to enter the input string
        Console.WriteLine("Enter the input string: ");
        
        // Read the input string from the user
        string input = Console.ReadLine();
        
        // Call the method to toggle the case of each character in the string
        string result = ToggleCase(input);
        
        // Display the modified string after toggling case
        Console.WriteLine("The modified string is: " + result);
    }

    // Method to toggle the case of each letter in the given string
    static string ToggleCase(string str)
    {
        // Create a character array to store the modified characters
        char[] charArray = new char[str.Length];

        // Iterate through each character in the string
        for (int i = 0; i < str.Length; i++)
        {
            // Store the current character in a variable
            char ch = str[i];

            // Check if the character is an uppercase letter
            if (ch >= 'A' && ch <= 'Z')
            {
                // Convert uppercase letter to lowercase by adding 32
                charArray[i] = (char)(ch + 32);
            }
            // Check if the character is a lowercase letter
            else if (ch >= 'a' && ch <= 'z')
            {
                // Convert lowercase letter to uppercase by subtracting 32
                charArray[i] = (char)(ch - 32);
            }
            // If the character is neither uppercase nor lowercase, keep it unchanged
            else
            {
                charArray[i] = ch;
            }
        }

        // Convert the character array back to a string and return it
        return new string(charArray);
    }
}