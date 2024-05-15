using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    //9.WAP to count frequency of each element in an array.
    public class Q9
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3 };
            int[] frequency = new int[arr.Length];
            // Initialize all frequencies to zero
            for (int i = 0; i < frequency.Length; i++)
            {
                frequency[i] = 0;
            }
            // Count the frequency of each element
            for (int i = 0; i < arr.Length; i++)
            {
                // Skip if the frequency of this element is already counted             if (frequency[i] != -1)
                {                 // Count the frequency of arr[i]
                    int count = 1; for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            // Mark arr[j] as counted by setting its frequency to -1 frequency[j] = -1;
                        }
                    }

                    // Store the frequency of arr[i] in the frequency array frequency[i] = count;
                }
            }
            // Print the frequencies
            for (int i = 0; i < arr.Length; i++)
            {
                if (frequency[i] != -1)
                {
                    Console.WriteLine($"Element {arr[i]}: Frequency {frequency[i]}");
                }
            }
        }
    }
}
