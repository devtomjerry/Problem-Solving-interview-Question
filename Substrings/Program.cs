using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substrings
{
    public class Program
    {
        public static List<string> GetAllSubstrings(string str)
        {
            List<string> substrings = new List<string>();
            for (int i = 0; i < str.Length; i++) 
            {
                for (int j = i +1; j <= str.Length; j++)
                {
                    string substring = str.Substring(i, j - i);
                    substrings.Add(substring);

                }
            }
            return substrings;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the string :");
            string input = Console.ReadLine();
            List<string> substrings = GetAllSubstrings(input);
            Console.WriteLine("substring of \"" + input + "\":");
            Console.ReadLine();
            foreach (string substring in substrings)
            {
                Console.WriteLine(substring);
                Console.ReadLine();
            }
        }
    }
}
