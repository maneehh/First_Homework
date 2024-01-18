using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 3
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int firstlargest = arr[0];
            int secondlargest = arr[0];

            foreach (int num in arr)
            {
                if (num > firstlargest)
                {
                    secondlargest = firstlargest;
                    firstlargest = num;
                }
                else if ( secondlargest > num && num < firstlargest )
                {
                    secondlargest = num;
                }
            }
            Console.WriteLine($"The second largest element is {secondlargest}");
        }
    }
}
