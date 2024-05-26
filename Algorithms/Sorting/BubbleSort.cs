using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDN.Algorithms.Sorting
{
    internal class BubbleSort
    {
        // O(n^2)
        internal static int[] SortArray(int[] arr)
        {
            //arr (sort) -> return arr;
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            return arr;
        }

        internal static void PrintArray(int[] arr)
        {
            foreach (var val in arr)
            {
                Console.WriteLine(val);
            }
        }
    }
}
