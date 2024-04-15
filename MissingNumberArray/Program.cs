using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11 }; 
            int n = numbers.Length + 1; 
            int totalSum = (n * (n + 1)) / 2; 
            int arraySum = 0;

            foreach (int num in numbers)
            {
                arraySum += num; 
            }

            int missingNumber = totalSum - arraySum;

            Console.WriteLine("The missing number is: " + missingNumber);
            Console.ReadLine();
        }
    }
}
