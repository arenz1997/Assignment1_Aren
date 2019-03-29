using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input the size of array: ");
            int size = int.Parse(Console.ReadLine()); 
            int[] a = new int[size];
            int i, j, k, max, min, average = 0;
            Console.WriteLine("Please input the elements of array...");
            for (i = 0; i < size; ++i) { a[i] = int.Parse(Console.ReadLine()); average += a[i]; }
            max = min = a[0];

            for (i = 0; i < size; ++i)
            {
                for (j = i; j < size; ++j)
                {
                    if (a[i] > a[j])
                    {
                        k = a[i];
                        a[i] = a[j];
                        a[j] = k;
                    }
                }
            }
            for (i = 0; i < size; ++i)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }
            Console.Write("Sorted array: ");
            for (i = 0; i < size; ++i)
            {
                Console.Write(a[i] + "\t");
            }

            Console.WriteLine("\nMin = " + min + ",\tMax = " + max + ",\tAverage = " + average/size+"\n");
            Console.ReadKey();
        }
    }
}