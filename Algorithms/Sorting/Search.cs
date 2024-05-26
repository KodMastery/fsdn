using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDN.Algorithms.Sorting
{
    internal class Search
    {
        /*
         * 1. RETURN THE VALUE OF THE TYPE
         * 2. HOW TO FIND IT (For)
         * 3. When we find it -> return the index of the target
         * O(n)
         */
        internal static int LinearSearch(int target, int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == target)
                {
                    //return index of target 
                    return i;
                }
            }

            return -1;
        }

        /*
         * O(logn)
         * 1. 
         */
        internal static int BinarySearch(int target, int[] arr)
        {
            int n = arr.Length;
            int left = 0;
            int right = n - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (target == arr[mid])
                {
                    return mid;
                }

                if (target < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

    }
}
