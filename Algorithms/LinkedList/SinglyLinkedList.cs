
namespace FSDN.Algorithms.LinkedList
{
    internal class SinglyLinkedList<T>
    {

        private Node head;

        //Big O(1)
        internal void AddFirst(T value)
        {
            Node firstNode = new Node(value);
            if (head == null)
            {
                head = firstNode;
            }
            else
            {
                firstNode.Next = head;
                head = firstNode;
            }
        }

        /*
         * O (n)
         */
        internal void Remove(T value)
        {
            if (head != null) 
            {
                if (head.Value.Equals(value))
                {
                    head = head.Next;
                }

                Node tmp = head;
                Node prev = null;
                while (tmp != null)
                {
                    if (tmp.Value.Equals(value))
                    {
                        prev.Next = tmp.Next;
                        break;
                    }

                    prev = tmp;
                    tmp = tmp.Next;
                }
            }
            
        }

        //O(n)
        internal void AddLast(T value)
        {
            Node lastNode = new Node(value);
            
            if (head == null)
            {
                head = lastNode;
            }

            else
            {
                Node tmp = head;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = lastNode;
            }
        }



        /*
         * ITERATE the whole LIST
         * For each Node check if the value is equal to "value"
         * if I find the value return true
         * otherwise if I do not find any value return false
         */

        //head = 1 value = 9
        //1 -> 5 -> 9 -> 22 -> null 22.Next = null

        //O (n)
        internal bool Contains(T value)
        {
            Node tmp = head;
            while (tmp != null)
            {
                if (tmp.Value.Equals(value)) return true;
                tmp = tmp.Next;
            }

            return false;
        }

        //Big O(n)
        internal void PrintList()
        {
            Node tmp = head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.Value);
                tmp = tmp.Next;
            }
        }
        //current = Node(4)
        //4->3->2

        private class Node
        {
            internal T Value { get; set; }
            internal Node Next { get; set; }

            internal Node(T value)
            {
                Value = value;
            }
        }

    }
}
