using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagram
{
    internal class Program
    {
        public class Anagram
        {
            public static bool areAnagram(string firstString, string secondString)
            {
                if (firstString.Length != secondString.Length)
                {
                    return false;
                } 
                char[] firstCharsArray = firstString.ToLower().ToCharArray();
                char[] secondCharsArray = secondString.ToLower().ToCharArray();
                Array.Sort(firstCharsArray);
                Array.Sort(secondCharsArray);
                for (int i = 0; i < firstCharsArray.Length; i++)
                {
                    if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static void Main(string[] args)
        {
            string firstString, secondString; 
            Console.WriteLine("Enter first string");
            firstString = Console.ReadLine();
            Console.WriteLine("Enter second string");
            secondString = Console.ReadLine();

            if (Anagram.areAnagram(firstString, secondString) == true)
            {
                Console.WriteLine("Both string are anagram string.");
            }
            else
            {
                Console.WriteLine("Both string are not anagram string.");
            }
            Console.ReadLine();
        }
    }
}