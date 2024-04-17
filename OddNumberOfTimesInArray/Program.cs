using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberOfTimesInArray
{
    internal class Program
    {
        static int FindOddNumber(int[] arr)
        {
            // Dictionary to store the count of each number
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            // Count occurrences of each number in the array
            foreach (int num in arr)
            {
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
            }

            // Find the number with an odd count
            foreach (var kvp in countMap)
            {
                if (kvp.Value % 2 != 0)
                {
                    return kvp.Key;
                }
            }

            // If no odd count is found, return -1 or handle as appropriate
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 4, 1, 3, 2, 4, 4 }; // Example array

            int oddNumber = FindOddNumber(arr);
            if (oddNumber != -1)
            {
                Console.WriteLine($"The number occurring odd number of times is: {oddNumber}");
            }
            else
            {
                Console.WriteLine("No number occurring odd number of times found.");
            }
        }
    }
}
