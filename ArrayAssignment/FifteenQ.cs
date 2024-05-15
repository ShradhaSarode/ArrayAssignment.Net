using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    /*15.	WAP to arrange the elements of an given array of integers
      where all negative integers appear before all the positive integers.*/
    public class FifteenQ
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, -3, 19, -29, 5, -61, 44, 7, -9 };

            RearrangeNegativesAndPositives(arr);

            Console.WriteLine("Array after rearrangement:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        static void RearrangeNegativesAndPositives(int[] arr)
        {
            int left = 0; // Pointer for negative integers
            int right = arr.Length - 1; // Pointer for positive integers

            while (left <= right)
            {
                // Move left pointer until a positive integer is found
                while (left <= right && arr[left] < 0)
                {
                    left++;
                }

                // Move right pointer until a negative integer is found
                while (left <= right && arr[right] >= 0)
                {
                    right--;
                }

                // Swap arr[left] and arr[right] if left pointer is less than right pointer
                if (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
        }
    }
}
