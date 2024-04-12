using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string orignalString = Console.ReadLine();
            string reverseString = string.Empty;
            for (int i = orignalString.Length - 1; i >= 0; i--)
            {
                reverseString += orignalString[i];
            }
            Console.WriteLine($"prinr string:{reverseString}");
            Console.ReadLine();
        }
    }
}