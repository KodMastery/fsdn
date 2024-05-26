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

        internal T GetHeadValue()
        {
            return head.Value;
        }

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
            Node tmp = tail;
            while (tmp != null)
            {
                Console.WriteLine(tmp.Value);
                tmp = tmp.Prev;
            }
        }

        internal T RemoveLast()
        {
            if (head == null && tail == null)
            {
                return default;
            }
            else if (head == tail)
            {
                T value = head.Value;
                head = null;
                tail = null;
                return value;
            }
            else
            {
                T valueToReturn = tail.Value;
                tail.Prev.Next = null;
                tail = tail.Prev;
                return valueToReturn;
            }
        }

        internal T GetLast()
        {
            if (head == null && tail == null)
            {
                return default;
            }

            return tail.Value;
        }

        internal void PrintListForQueue()
        {
            Node tmp = head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.Value);
                tmp = tmp.Next;
            }
        }

        internal T RemoveFirst()
        {
            if (head == null && tail == null)
            {
                return default;
            }

            if (head == tail)
            {
                T removed = head.Value;
                head = null;
                tail = null;
                return removed;
            }
            else
            {
                T removed = head.Value;
                head.Next.Prev = null;
                head = head.Next;
                return removed;
            }
        }

        internal bool Contains(T element)
        {
            Node tmp = head;
            while (tmp != null)
            {
                if (tmp.Value.Equals(element))
                {
                    return true;
                }
                tmp = tmp.Next;
            }
            return false;
        }
    }
}
