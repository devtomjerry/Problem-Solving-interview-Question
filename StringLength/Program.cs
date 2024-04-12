using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter the string :");
            input = Console.ReadLine();
            int x =0;
            foreach (char c in input)
            {
                Console.WriteLine(input[x]);
                x++;
            }
            Console.WriteLine("\nLength of string:{0}", (x));
            Console.ReadLine();
        }
    }
}
