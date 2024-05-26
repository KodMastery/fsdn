using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSDN.Algorithms.LinkedList;

namespace FSDN.Algorithms.Dequeue
{
    internal class MyDequeue<T>
    {
        private DoublyLinkedList<T> list = new DoublyLinkedList<T>();

        //AddFirst
        internal void AddFirst(T element)
        {
            list.AddFirst(element);
        }

        //AddLast
        internal void AddLast(T element)
        {
            list.AddLast(element);
        }

        //RemoveFirst
        internal T RemoveFirst()
        {
            return list.RemoveFirst();
        }

        //RemoveLast
        internal T RemoveLast()
        {
            return list.RemoveLast();
        }

        //Print
        internal void Print()
        {
            list.PrintListForQueue();
        }

        //Contains()
        internal bool Contains(T element)
        {
            return list.Contains(element);
        }
    }
}
