using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*12.WAP to reverse the array itself, don’t print array in reverse –
 * I want current array reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78] 
 * so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array.*/
namespace ArrayAssignment
{
    public class TwelveQ
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 90, 45, 29, 37, 78 };

            ReverseArray(numbers);

            Console.WriteLine("Reversed array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }

        static void ReverseArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                // Swap elements at start and end indices
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                // Move to the next pair of elements
                start++;
                end--;
            }
        }
    }
}
