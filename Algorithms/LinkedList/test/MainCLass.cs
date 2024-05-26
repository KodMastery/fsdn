

using FSDN.Algorithms.Queue;

namespace FSDN.Algorithms.LinkedList.test
{
    internal class MainCLass
    {
        public static void Main(string[] args)
        {
            int[] arr = {8, 10, -5, 18, 60, 99};

            List<int> list = BiggerThanTarget(15, arr);

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

        }
        static List<int> BiggerThanTarget(int target, int[] arr)
        {
            //check if arr has at least 1 element

            List<int> list = new List<int>();

            /*
             * code
             */


            return list;
        }

        static int FindBiggestNumber(int[] arr)
        {
            //check if array has at least one element :)
            if (arr.Length == 0) return default;

            int x = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                //is x smaller than the element we are currently iterating?
                //if yes -> x = the current element
                if (x < arr[i])
                {
                    x = arr[i];
                }
            }

            return x;
        }
    }
}
