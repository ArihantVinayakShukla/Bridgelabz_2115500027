using System;

class FreqChar{

    static void Main(string[] args){
    
        // Prompt the user to enter the input string
        Console.WriteLine("Enter the input string: ");
        
        // Read the input string from the user
        string input = Console.ReadLine();
        
        // Call the method to find the most frequent character
        char result = CharOccurence(input.ToLower());
        
        // Display the most frequent character
        Console.WriteLine("Most Frequent Character: " + result);
    }
    
    // Method to find the most frequently occurring character in a string
    static char CharOccurence(string str){
    
        // Variable to keep track of the highest occurrence count
        int maxCount = 0;
        
        // Variable to store the count of current character
        int prevCount = 0;
        
        // Variable to store the most frequently occurring character
        char maxOcc = ' ';

        // Iterate through each character in the string
        for(int i = 0; i < str.Length; i++){
            
            // Reset previous count for the current character
            prevCount = 0;
            
            // Iterate through the remaining characters to count occurrences
            for(int j = i+1; j < str.Length; j++){
                
                // If the current character matches another character, increase count
                if(str[i] == str[j]){
                    prevCount++;
                }
            }
            
            // If the current character occurs more than the previous max, update max
            if(prevCount > maxCount){
                maxCount = prevCount;
                maxOcc = str[i];
            }
        }
        
        // Return the most frequently occurring character
        return maxOcc;
    }
}
