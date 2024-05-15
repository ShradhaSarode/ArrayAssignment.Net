using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    //4.WAP to put even and odd elements of array in two separate arrays.
    public class FourthQ
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 7, 8, 10, 13, 17, 20 };

            int[] evenArray;
            int[] oddArray;

            SeparateEvenOdd(numbers, out evenArray, out oddArray);

            Console.WriteLine("Even elements:");
            PrintArray(evenArray);

            Console.WriteLine("\nOdd elements:");
            PrintArray(oddArray);
        }

        static void SeparateEvenOdd(int[] array, out int[] evenArray, out int[] oddArray)
        {
            int evenCount = 0;
            int oddCount = 0;

            // Count the number of even and odd elements
            foreach (int num in array)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            // Initialize even and odd arrays with their respective sizes
            evenArray = new int[evenCount];
            oddArray = new int[oddCount];

            // Fill even and odd arrays with elements
            int evenIndex = 0;
            int oddIndex = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                    evenArray[evenIndex++] = num;
                else
                    oddArray[oddIndex++] = num;
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
