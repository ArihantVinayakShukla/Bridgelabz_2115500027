using System;

class SubstringOcc{

    static void Main(string[] args){
    
        // Prompt the user to enter the main string
        Console.WriteLine("Enter the input string: ");
        
        // Read the input string from the user
        string input = Console.ReadLine();
        
        // Prompt the user to enter the substring to search for
        Console.WriteLine("Enter the subString: ");
        
        // Read the substring from the user
        string subStr = Console.ReadLine();
        
        // Call method to count occurrences of the substring
        int occurences = CountOccurences(input, subStr);
        
        // Display the number of times the substring appears in the input string
        Console.WriteLine("The number of times the substring " + subStr + " has occurred in " + input + " is: " + occurences);
    }
    
    // Method to count occurrences of a substring in a string
    static int CountOccurences(string str, string subStr){
        
        // Variable to store the count of occurrences
        int count = 0;
        
        // Length of the main string
        int n = str.Length;
        
        // Length of the substring
        int m = subStr.Length;
        
        // Loop through the main string, stopping when there aren't enough characters left to match the substring
        for(int i = 0; i <= n - m; i++){
            
            // Flag to check if substring matches
            bool match = true;
            
            // Check if characters of substring match in main string at the current position
            for(int j = 0; j < m; j++){
                
                // If any character doesn't match, set flag to false and break
                if(str[i + j] != subStr[j]){
                    match = false;
                    break;
                }
            }
            
            // If a full match is found, increment count
            if(match){
                count++;
            }
        }
        
        // Return the total count of occurrences
        return count;
    }
}
