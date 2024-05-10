
namespace FSDN.Algorithms.LinkedList
{
    public class DoublyCustomLinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }

            internal Node(T data)
            {
                this.Data = data;
                this.Next = null;
                this.Prev = null;
            }
        }

        private Node head = null;
        private Node tail = null;

        public void AddFirst(T data)
        {
            Node firstNode = new Node(data);
            if (head == null)
            {
                tail = firstNode;
            }
            else
            {
                firstNode.Next = head;
                head.Prev = firstNode;
            }
            head = firstNode;
        }

        public void AddLast(T data)
        {
            Node lastNode = new Node(data);
            if (head == null)
            {
                head = lastNode;
            }
            else
            {
                tail.Next = lastNode;
                lastNode.Prev = tail;
            }

            tail = lastNode;
        }

        public bool Remove(T data)
        {
           Node current = head;
           while (current != null)
           {
               if (current.Data.Equals(data))
               {
                    ValidatePositionAndRemoveNode(current);
               }
               current = current.Next;
           }

           return false;
        }

        private void ValidatePositionAndRemoveNode(Node current)
        {
            //check if there is only one node
            if (current == head && current == tail)
            {
                tail = null;
                head = null;
            }
            else if (current == head && current != tail)
            {
                current.Next.Prev = null;
                head = current.Next;
            }
            else if (current != head && current == tail)
            {
                current.Prev.Next = null;
                tail = current;
            }
            else
            {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
            }
        }

        public void PrintAll()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }

}
