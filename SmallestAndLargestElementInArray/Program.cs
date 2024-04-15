using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestAndLargestElementInArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Element in the Array :");
            int n = int.Parse(Console.ReadLine());

            int [] numbers = new int[n];

            Console.WriteLine("Enter the Element of the array :");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element {0}: ",i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int smallest = numbers[0];
            int largest = numbers[0];

            for (int i = 1 ; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("Smallest Elements: " + smallest);
            Console.WriteLine("Largest Elements:" + largest);
            Console.ReadLine();
        }
    }
}
