using System;
using System.Collections.Generic;

class Program
{
    static void FindDuplicateCharacters(string str)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Count occurrences of each character
        foreach (char c in str)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        Console.WriteLine("Duplicate characters in the string:");
        foreach (var kvp in charCount)
        {
            if (kvp.Value > 1)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} occurrences");
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        FindDuplicateCharacters(input);
        Console.ReadLine();
    }
}