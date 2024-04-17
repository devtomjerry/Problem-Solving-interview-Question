using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumElementSortedAndRotatedArray
{
    public class Program
    {
        static void Main()
        {
            int[] arr = { 5, 6, 7, 8, 22, 31 };
            int min = FindMin(arr);
            Console.WriteLine("Minimum element is: " + min);
            Console.ReadLine();        }

        static int FindMin(int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] > arr[high])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return arr[low];
        }
    }
}
