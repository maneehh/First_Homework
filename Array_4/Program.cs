using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 4
            Console.Write("Enter the number of elements in the arrays: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];
            int[] sumArray = new int[n];

            Console.Write("Enter elements for the first array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter elements for the second array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array2[i] = Convert.ToInt32(Console.ReadLine());

                sumArray[i] = array1[i] + array2[i];
            }

            Console.WriteLine("Sum of arrays: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Element {i + 1}: {sumArray[i]}");
            }
        }
    }
}
