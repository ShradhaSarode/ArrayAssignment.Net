using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.	WAP to print all negative elements in an array and also count total number of negative elements in an array
namespace ArrayAssignment
{
    public class ThirdQ
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, -5, 7, -3, -9, 10, 4, -8 };

            Console.WriteLine("Negative elements in the array:");
            PrintNegativeElements(numbers);

            int count = CountNegativeElements(numbers);
            Console.WriteLine("Total number of negative elements: " + count);
        }

        static void PrintNegativeElements(int[] array)
        {
            foreach (int num in array)
            {
                if (num < 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static int CountNegativeElements(int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
