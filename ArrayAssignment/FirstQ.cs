using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	WAP to search for a given number in an array and accordingly print the index if exists*/
namespace ArrayAssignment
{
    public class FirstQ
    {
        static void Main(string[] args)
        {
            // Sample array
            int[] numbers = { 1, 5, 8, 10, 15 };

            // Number to search
            int searchNumber = 10;

            // Perform the search
            int index = SearchNumber(numbers, searchNumber);

            // Print the result
            if (index != -1)
            {
                Console.WriteLine("Number {0} found at index {1}.", searchNumber, index);
            }
            else
            {
                Console.WriteLine("Number {0} not found in the array.", searchNumber);
            }
        }

        static int SearchNumber(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i; // Return the index if the number is found
                }
            }
            return -1; // Return -1 if the number is not found
        }
    }
}
