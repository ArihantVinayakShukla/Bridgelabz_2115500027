using System;

class CompareStr
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first input string: ");
        string firstInput = Console.ReadLine();

        Console.WriteLine("Enter the second input string: ");
        string secondInput = Console.ReadLine();

        string result = CompareLexically(firstInput, secondInput);
        Console.WriteLine(result);
    }

    static string CompareLexically(string str1, string str2)
    {
		// Get the length of the shorter string
        int n = str1.Length < str2.Length ? str1.Length : str2.Length;  

        // Compare each character one by one
        for (int i = 0; i < n; i++)
        {
            char ch1 = str1[i];
            char ch2 = str2[i];

            // Convert characters to lower case manually by checking ASCII values
            if (ch1 >= 'A' && ch1 <= 'Z')
                ch1 = (char)(ch1 + 32);  // Convert uppercase to lowercase

            if (ch2 >= 'A' && ch2 <= 'Z')
                ch2 = (char)(ch2 + 32);  // Convert uppercase to lowercase

            // Compare the two characters
            if (ch1 < ch2)
            {
                return str1 + " comes before " + str2 + " in lexicographical order.";
            }
            else if (ch1 > ch2)
            {
                return str2 + " comes before " + str1 + " in lexicographical order.";
            }
        }

        // If we reach here, the strings are identical up to the length of the shorter one
        if (str1.Length < str2.Length)
        {
            return str1 + " comes before " + str2 + " in lexicographical order.";
        }
        else if (str1.Length > str2.Length)
        {
            return str2 + " comes before " + str1 + " in lexicographical order.";
        }

        return "Both strings are identical.";
    }
}
