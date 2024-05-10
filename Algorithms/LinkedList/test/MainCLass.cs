using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDN.Algorithms.LinkedList.test
{
    internal class MainCLass
    {
        public static void Main(string[] args)
        {
            SinglyLinkedList<string> list = new SinglyLinkedList<string>();
            list.AddFirst("Hey");
            list.AddLast("Last");
            list.AddLast("Now i Am Last");
            list.AddFirst("Now i am first");
            list.PrintList();
            list.Remove("Hey");
            Console.WriteLine();
            list.PrintList();
            Console.WriteLine(list.Contains("Hey"));
        }
    }
}
