using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2
            Console.Write("Enter the number of elements in the array: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int up = 0;
            int down = num - 1;

            while (up < down)
            {
                int temp = arr[up];
                arr[up] = arr[down];
                arr[down] = temp;

                up++;
                down--;
            }

            Console.WriteLine("Reversed array");

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Element {i + 1}: {arr[i]}");
            }
            Console.ReadKey();
        }
    }
}
