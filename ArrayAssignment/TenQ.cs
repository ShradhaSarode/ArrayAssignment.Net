using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10.	WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
namespace ArrayAssignment
{
    public class TenQ
    {
        static void Main(string[] args)
        {
            int[] array1 = { 2, 5, 7, 8, 10 };
            int[] array2 = { 5, 8, 12, 15, 20 };

            int[] mergedArray = MergeArrays(array1, array2);

            Console.WriteLine("Merged array without duplicates:");
            foreach (int num in mergedArray)
            {
                Console.Write(num + " ");
            }
        }

        static int[] MergeArrays(int[] array1, int[] array2)
        {
            HashSet<int> uniqueSet = new HashSet<int>();

           
            foreach (int num in array1)
            {
                uniqueSet.Add(num);
            }

            
            foreach (int num in array2)
            {
                if (!uniqueSet.Contains(num))
                {
                    uniqueSet.Add(num);
                }
            }

            
            int[] mergedArray = new int[uniqueSet.Count];
            uniqueSet.CopyTo(mergedArray);

            return mergedArray;
        }
    }
}
