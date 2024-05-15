using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    //8.	WAP to find the second smallest element in an array
    public class EightQ
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 2, 10, 3, 7 };

            int secondSmallest = FindSecondSmallest(numbers);

            Console.WriteLine("Second smallest element in the array: " + secondSmallest);
        }

        static int FindSecondSmallest(int[] array)
        {
            if (array.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements.");
            }

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in array)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if (num < secondSmallest && num != smallest)
                {
                    secondSmallest = num;
                }
            }

            if (secondSmallest == int.MaxValue)
            {
                throw new ArgumentException("There is no second smallest element in the array.");
            }

            return secondSmallest;
        }
    }
}
