using System;

// Program to check if two strings are anagrams
class AnagramChecker 
{
    // Method to check if two strings are anagrams
    public static bool AreAnagrams(string str1, string str2)
    {
        // If lengths are different, they can't be anagrams
        if (str1.Length != str2.Length)
        {
            return false;
        }
        
        // Create character count arrays
        int[] charCount1 = new int[256];
        int[] charCount2 = new int[256];
        
        // Count characters in both strings
        for (int i = 0; i < str1.Length; i++)
        {
            charCount1[str1[i]]++;
            charCount2[str2[i]]++;
        }
        
        // Compare character counts
        for (int i = 0; i < 256; i++)
        {
            if (charCount1[i] != charCount2[i])
            {
                return false;
            }
        }
        
        return true;
    }
    
    // Main method to test the program
    static void Main(string[] args)
    {
        // Get input strings from user
        Console.WriteLine("Anagram Checker");
        Console.WriteLine("--------------");
        
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();
        
        // Check if strings are anagrams
        bool areAnagrams = AreAnagrams(str1.ToLower(), str2.ToLower());
        
        // Display result
        Console.WriteLine("\nResults:");
        Console.WriteLine("First String: " + str1);
        Console.WriteLine("Second String: " + str2);
        Console.WriteLine("Are these strings anagrams? " + (areAnagrams ? "Yes" : "No"));
    }
}