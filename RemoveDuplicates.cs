using System;

class RemoveDuplicates{

    static void Main(string[] args){
    
        // Prompt the user for input
        Console.Write("Enter the input string: "); 
        string input = Console.ReadLine();
        
        // Call method to remove duplicates
        string dupRemStr = Duplicate(input);
        
        // Display the modified string
        Console.WriteLine("Modified string: " + dupRemStr);
        
    }
    
    // Method to remove duplicate characters from the string
    static string Duplicate(string str){
        
        // Convert string to character array
        char[] charArray = str.ToCharArray(); 
        int n = charArray.Length;
		
        // Index to track unique characters
        int writeIndex = 0; 
        
        for(int i = 0; i < n; i++){
            // Flag to check if the character is a duplicate
            bool isDuplicate = false; 
            
            for(int j = 0; j < writeIndex; j++){
                
                if(charArray[i] == charArray[j]){
                    
                    isDuplicate = true;
                    break; 
                }
            }
            
            // If the character is unique, add it to the result
            if(!isDuplicate){ 
                
                charArray[writeIndex] = charArray[i];
                writeIndex++;
            }
        }
        
        // Construct the result string from unique characters
        string result = "";
        for(int i = 0; i < writeIndex; i++){
            result += charArray[i]; 
        }
    
        return result;
    }
}
