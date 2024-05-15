using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.	Write two methods that return the average of an array with following headers.
namespace ArrayAssignment
{
    public class SecondQ
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 4, 6, 8, 10 };
            double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };

            int intArrayAverage = Average(intArray);
            double doubleArrayAverage = Average(doubleArray);

            Console.WriteLine("Average of integer array: " + intArrayAverage);
            Console.WriteLine("Average of double array: " + doubleArrayAverage);
        }

        // Method to calculate the average of an array of integers
        public static int Average(int[] array)
        {
            if (array.Length == 0)
                return 0; // return 0 if the array is empty

            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum / array.Length;
        }

        // Method to calculate the average of an array of doubles
        public static double Average(double[] array)
        {
            if (array.Length == 0)
                return 0; // return 0 if the array is empty

            double sum = 0;
            foreach (double num in array)
            {
                sum += num;
            }
            return sum / array.Length;
        }
    }
}
