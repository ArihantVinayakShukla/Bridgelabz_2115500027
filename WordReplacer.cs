using System;

// Program to replace words in a sentence
class WordReplacer 
{
    // Method to replace a word in a sentence
    public static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        // Create array to store result
        char[] result = new char[sentence.Length * 2];
        int resultIndex = 0;
        int sentenceIndex = 0;
        
        while (sentenceIndex < sentence.Length)
        {
            // Check if current position matches oldWord
            bool isMatch = true;
            for (int i = 0; i < oldWord.Length && sentenceIndex + i < sentence.Length; i++)
            {
                if (sentence[sentenceIndex + i] != oldWord[i])
                {
                    isMatch = false;
                    break;
                }
            }
            
            // If match found, add newWord to result
            if (isMatch && (sentenceIndex + oldWord.Length <= sentence.Length))
            {
                // Check if it's a whole word by checking boundaries
                bool isWholeWord = true;
                if (sentenceIndex > 0 && char.IsLetter(sentence[sentenceIndex - 1]))
                {
                    isWholeWord = false;
                }
                if (sentenceIndex + oldWord.Length < sentence.Length && 
                    char.IsLetter(sentence[sentenceIndex + oldWord.Length]))
                {
                    isWholeWord = false;
                }
                
                if (isWholeWord)
                {
                    for (int i = 0; i < newWord.Length; i++)
                    {
                        result[resultIndex] = newWord[i];
                        resultIndex++;
                    }
                    sentenceIndex += oldWord.Length;
                }
                else
                {
                    result[resultIndex] = sentence[sentenceIndex];
                    resultIndex++;
                    sentenceIndex++;
                }
            }
            // If no match, copy original character
            else
            {
                result[resultIndex] = sentence[sentenceIndex];
                resultIndex++;
                sentenceIndex++;
            }
        }
        
        // Convert result array to string
        string outputString = "";
        for (int i = 0; i < resultIndex; i++)
        {
            outputString += result[i];
        }
        
        return outputString;
    }
    
    // Main method to test the program
    static void Main(string[] args)
    {
        // Get input from user
        Console.WriteLine("Word Replacement Program");
        Console.WriteLine("----------------------");
        
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();
        
        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();
        
        // Replace word and display result
        string modifiedSentence = ReplaceWord(sentence, oldWord, newWord);
        
        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Original Sentence: " + sentence);
        Console.WriteLine("Word to Replace: " + oldWord);
        Console.WriteLine("New Word: " + newWord);
        Console.WriteLine("Modified Sentence: " + modifiedSentence);
    }
}