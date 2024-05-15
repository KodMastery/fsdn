using System.Collections;
using FSDN.Algorithms.HashBased;

namespace FSDN.Algorithms.LinkedList.test
{
    internal class MainCLass
    {
        public static void Main(string[] args)
        {
            HashTable<string, int> table = new HashTable<string, int>();
            table.Add("Sunrise", 5);
            table.Add("Evening", 19);
            table.Add("Morning", 8);
            table.Add("Morning", 10);
            table.Add("Sunrise", 190);
            table.Add("Evening", 321);
            table.Add("Morning", 832);
            table.Add("Morning", 321321321);

            int value = table.Get("Sunrise");
            Console.WriteLine(value);

            for (int i = 0; i < 1000000; i++)
            {
                table.Add(i.ToString(), i);
            }

            //O(n) 1000000/100 => 10000 O(n/100)
            table.Add("9999", 999999);
        }
    }
}
