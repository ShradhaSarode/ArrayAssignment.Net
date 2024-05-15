using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*13.Write a  program to test the equality of two arrays. 
  Means e.g arr1[] = [12, 22, 32, 42, 52, 62] and arr2[]
  = [52, 22, 62, 12, 42, 22] Here both arrays are equal.*/
namespace ArrayAssignment
{
    public class ThirteenQ
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = { 52, 22, 62, 12, 42, 22 };

            bool areEqual = AreArraysEqual(arr1, arr2);

            if (areEqual)
            {
                Console.WriteLine("Both arrays are equal.");
            }
            else
            {
                Console.WriteLine("Both arrays are not equal.");
            }
        }

        static bool AreArraysEqual(int[] arr1, int[] arr2)
        {
            // Check if both arrays have the same length
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            // Sort both arrays to ensure elements are in the same order
            Array.Sort(arr1);
            Array.Sort(arr2);

            // Compare each element of both arrays
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            // If all elements match, the arrays are equal
            return true;
        }
    }
}
