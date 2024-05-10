namespace FSDN.Algorithms.LinkedList.test
{
    public class CustomLinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;

        public void AddFirst(T data)
        {
            Node newNode = new Node(data) { Next = head };
            head = newNode;
        }

        public void AddLast(T data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool Remove(T data)
        {
            Node current = head;
            Node previous = null;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous == null)
                    {
                        head = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
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
