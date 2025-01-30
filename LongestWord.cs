using System;

class LongestWord{

    static void Main(string[] args){
    
        // Prompt the user for input
        Console.WriteLine("Enter the sentence: ");
        
        // Read the input sentence from the user
        string sentence = Console.ReadLine();
        
        // Find the longest word in the given sentence
        string longestWord = FindLongestWord(sentence);
        
        // Display the longest word
        Console.WriteLine("Longest Word: " + longestWord);
    }
    
    // Method to find the longest word in a given sentence
    static string FindLongestWord(string sentence){
        
        // Variable to store the maximum length of a word
        int maxLength = 0;
        
        // Variable to store the longest word
        string longestWord = "";
        
        // Temporary variable to hold the current word
        string currentWord = "";
        
        // Loop through each character in the sentence
        for(int i = 0; i < sentence.Length; i++){
            
            // If the character is not a space, add it to the current word
            if(sentence[i] != ' '){
                currentWord += sentence[i];
            } 
            // If we encounter a space, check if the current word is the longest so far
            else {
                if(currentWord.Length > maxLength){
                    
                    // Update maxLength and store the longest word found so far
                    maxLength = currentWord.Length;
                    longestWord = currentWord;
                }
                
                // Reset current word for the next word in the sentence
                currentWord = "";
            }
        }
        
        // Check the last word in case the sentence does not end with a space
        if(currentWord.Length > maxLength){
            
            // Update longestWord if the last word is the longest
            longestWord = currentWord;
        }
        
        // Return the longest word found
        return longestWord;
    }
}
