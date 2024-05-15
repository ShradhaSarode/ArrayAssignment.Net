using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    /*14.	WAP to replace all negative value with its immediate left elements square.
      Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9]
      Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].*/
    public class FourteenQ
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };

            ReplaceNegativesWithLeftSquare(arr);

            Console.WriteLine("Output array after replacement:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        static void ReplaceNegativesWithLeftSquare(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    if (i > 0)
                    {
                        arr[i] = arr[i - 1] * arr[i - 1]; // Square of the immediate left element
                    }
                    else
                    {
                        arr[i] = 0; // If there's no left element, set it to 0
                    }
                }
            }
        }
    }
}
