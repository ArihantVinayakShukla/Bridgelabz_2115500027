using System;

class ReverseString
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Reverse the string manually
        string reversed = Reverse(input);

        // Display the reversed string
        Console.WriteLine("Reversed string: " + reversed);
    }

    static string Reverse(string str)
    {
        // Convert string to a character array
        char[] charArray = new char[str.Length];

        // Manually copy characters in reverse order
        for (int i = 0; i < str.Length; i++)
        {
            charArray[str.Length - 1 - i] = str[i];
        }

        // Convert the reversed character array back to a string
        return new string(charArray);
    }
}
