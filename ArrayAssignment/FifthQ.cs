using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    //5.	WAP to find the maximum and minimum value in an array.
    public class FifthQ
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 7, 8, 10, 13, 17, 20 };

            int max = FindMax(numbers);
            int min = FindMin(numbers);

            Console.WriteLine("Maximum value in the array: " + max);
            Console.WriteLine("Minimum value in the array: " + min);
        }

        static int FindMax(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array is empty or null.");

            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        static int FindMin(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array is empty or null.");

            int min = array[0];
            foreach (int num in array)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }
    }
}
