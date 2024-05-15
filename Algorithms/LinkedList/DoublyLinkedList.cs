using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDN.Algorithms.LinkedList
{
    internal class DoublyLinkedList<T>
    {
        private class Node
        {
            internal T Value { get; set; }
            internal Node Next { get; set; }
            internal Node Prev { get; set; }

            internal Node(T value)
            {
                Value = value;
            }
        }

        private Node head;
        private Node tail;

        internal void AddFirst(T value)
        {
            Node a = new Node(value);
            //1 if its empty -> set head and tail to the first Node
            if (head == null && tail == null)
            {
                head = a;
                tail = a;
            }
            else
            {
                //2 a.next = head. head.prev = a. head = a
                a.Next = head;
                head.Prev = a;
                head = a;
            }

        }

        internal void AddLast(T value)
        {
            Node a = new Node(value);
            //1 if its empty -> set head and tail to the first Node
            if (head == null && tail == null)
            {
                head = a;
                tail = a;
            }
            else
            {
                tail.Next = a;
                a.Prev = tail;
                tail = a;
            }

        }

        internal void Remove(T value)
        {
            Node tmp = head;
            while (tmp != null)
            {
                if (tmp.Value.Equals(value))
                {
                    ValidatePositionAndRemoveNode(tmp);
                }
                tmp = tmp.Next;
            }
        }

        private void ValidatePositionAndRemoveNode(Node tmp)
        {
            if (tmp == head && tmp == tail)
            {
                head = null;
                tail = null;
            }
            else if (tmp == head && tmp != tail)
            {
                tmp.Next.Prev = null;
                head = tmp.Next;
            }
            else if (tmp != head && tmp == tail)
            {
                tmp.Prev.Next = null;
                tail = tmp.Prev;
            }
            else
            {
                tmp.Prev.Next = tmp.Next;
                tmp.Next.Prev = tmp.Prev;
            }
        }

        internal void PrintList()
        {
            Node tmp = head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.Value);
                tmp = tmp.Next;
            }
        }
    }
}
