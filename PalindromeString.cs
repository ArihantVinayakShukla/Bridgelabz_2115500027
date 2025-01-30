using System;

class PalindromeString{

	static void Main(string[] args){
	
		// Prompt the user for input
		Console.WriteLine("Enter the input string: ");
		string input = Console.ReadLine();
		
		bool isPalindrome = Palindrome(input);

        // Display the reversed string
        Console.WriteLine("Is the given string palindrome: " + isPalindrome);
	
	}
	
	static bool Palindrome(string input){
		
		// Convert string to a character array
        char[] charArray = new char[input.Length];

        // Manually copy characters in reverse order
        for (int i = 0; i < input.Length; i++)
        {
            charArray[input.Length - 1 - i] = input[i];
        }

        // Convert the reversed character array back to a string 
		// and compare it with the original string
        return input == (new string(charArray));
		
	}

}