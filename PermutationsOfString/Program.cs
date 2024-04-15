using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationsOfString
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to permute:");
            string str = Console.ReadLine();  

            if (str != null)
            {
                List<string> results = new List<string>();
                Permute(str.ToCharArray(), 0, str.Length - 1, results);

                Console.WriteLine("All permutations:");
                foreach (var permutation in results)
                {
                    Console.WriteLine(permutation);
                    Console.ReadLine();
                }
            }
        }

        private static void Permute(char[] array, int startIndex, int endIndex, List<string> results)
        {
            if (startIndex == endIndex)
            {
                results.Add(new String(array));
            }
            else
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    Swap(ref array[startIndex], ref array[i]);
                    Permute(array, startIndex + 1, endIndex, results);
                    Swap(ref array[startIndex], ref array[i]);
                }
            }
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}