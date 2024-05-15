using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    //6.	WAP to find and count total number of duplicate elements in an array.
    public class SixthQ
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 7, 8, 10, 13, 2, 17, 20, 5 };

            Dictionary<int, int> frequencyMap = CountDuplicates(numbers);

            int totalDuplicates = 0;

            Console.WriteLine("Duplicate elements in the array:");

            foreach (var pair in frequencyMap)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine(pair.Key + " (count: " + pair.Value + ")");
                    totalDuplicates += pair.Value - 1; // Subtract 1 to exclude the original occurrence
                }
            }

            Console.WriteLine("Total number of duplicate elements: " + totalDuplicates);
        }

        static Dictionary<int, int> CountDuplicates(int[] array)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (frequencyMap.ContainsKey(num))
                    frequencyMap[num]++;
                else
                    frequencyMap[num] = 1;
            }

            return frequencyMap;
        }
    }
}
