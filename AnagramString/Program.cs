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
                //Convert string to character array  
                char[] firstCharsArray = firstString.ToLower().ToCharArray();
                char[] secondCharsArray = secondString.ToLower().ToCharArray();
                //Sort array  
                Array.Sort(firstCharsArray);
                Array.Sort(secondCharsArray);
                //Check each character and position.  
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
            //Gets words from user.  
            Console.WriteLine("Enter first string");
            firstString = Console.ReadLine();
            Console.WriteLine("Enter second string");
            secondString = Console.ReadLine();

            //Check if words are anagram  
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