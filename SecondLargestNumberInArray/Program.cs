using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargestNumberInArray
{
    public class Program
    {
        static void Main()
        {
            int[] array = { 12, 35, 1, 10, 45, 1 };
            var result = FindSecondLargest(array);
            if (result.HasValue)
            {
                Console.WriteLine("The second largest element is " + result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No second largest element found.");
                Console.ReadLine();
            }
        }

        static int? FindSecondLargest(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return null;
            }

            int first = int.MinValue;
            int second = int.MinValue;

            foreach (int num in array)
            {
                if (num > first)
                {
                    second = first;
                    first = num;
                }
                else if (num > second && num != first)
                {
                    second = num;
                }
            }

            if (second == int.MinValue)
            {
                return null;
            }
            return second;
        }
    }
}
