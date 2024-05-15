using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    //7.	WAP to print all unique elements in the array.
    public class SevenQ
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 7, 8, 10, 13, 2, 17, 20, 5 };

            List<int> uniqueElements = FindUniqueElements(numbers);

            Console.WriteLine("Unique elements in the array:");
            foreach (int num in uniqueElements)
            {
                Console.WriteLine(num);
            }
        }

        static List<int> FindUniqueElements(int[] array)
        {
            HashSet<int> uniqueSet = new HashSet<int>();
            List<int> uniqueElements = new List<int>();

            foreach (int num in array)
            {
                if (!uniqueSet.Contains(num))
                {
                    uniqueSet.Add(num);
                    uniqueElements.Add(num);
                }
            }

            return uniqueElements;
        }
    }
}
