using System;
using System.Collections.Generic;

namespace UniqueCharacters
{
    internal class Program
    {
        public static bool HasUniqueCharacters(string str)
        {
            HashSet<char> charSet = new HashSet<char>();

            foreach (char c in str)
            {
                if (charSet.Contains(c))
                {
                    return false;
                }
                charSet.Add(c);
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check:");
            string input = Console.ReadLine();

            bool result = HasUniqueCharacters(input);
            if (result)
            {
                Console.WriteLine($"{input} has all unique characters.");
            }
            else
            {
                Console.WriteLine($"{input} does not all unique characters.");
            }

            Console.ReadLine();
        }
    }
}