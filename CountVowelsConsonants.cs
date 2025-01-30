using System;

class CountVowelsConsonants
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a string
        Console.WriteLine("Enter the input string: ");
        
        // Read user input
        string input = Console.ReadLine();

        // Call the method and store the result
        string result = CountVowCon(input);

        // Print the result
        Console.WriteLine(result);
    }

    static string CountVowCon(string input)
    {
        // Initialize vowel and consonant counters
        int vowels = 0, consonants = 0;

        // Convert the input string to lowercase to simplify checking
        input = input.ToLower();

        // Iterate over each character in the string
        foreach (char ch in input)
        {
            // Check if the character is a letter (ignoring spaces, numbers, and special characters)
            if (char.IsLetter(ch))
            {
                // Check if the character is a vowel
                if ("aeiou".Contains(ch.ToString())) // Convert char to string
                {
                    vowels++;
                }
                else // If not a vowel, it's a consonant
                {
                    consonants++;
                }
            }
        }

        // Return the result as a concatenated string
        return "The number of vowels are " + vowels + " and the number of consonants are " + consonants + " in the string \"" + input + "\".";
    }
}
