using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//11.	WAP sort array elements in ascending order.
namespace ArrayAssignment
{
    public class ElevanQ
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 7, 3, 1 };

            Array.Sort(numbers);

            Console.WriteLine("Sorted array in ascending order:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
