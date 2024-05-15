using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9.	WAP to count frequency of each element in an array.
namespace ArrayAssignment
{
    public class NineQ
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 7, 8, 10, 13, 2, 17, 20, 5 };

            Dictionary<int, int> frequencyMap = CountFrequency(numbers);

            Console.WriteLine("Frequency of each element in the array:");
            foreach (var pair in frequencyMap)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
        }

        static Dictionary<int, int> CountFrequency(int[] array)
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
