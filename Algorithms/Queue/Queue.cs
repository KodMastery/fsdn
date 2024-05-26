
using FSDN.Algorithms.LinkedList;

namespace FSDN.Algorithms.Queue
{
    internal class MyQueue<T>
    {
        private DoublyLinkedList<T> list = new DoublyLinkedList<T>();

        internal void Enqueue(T element)
        {
            //add from the top
            list.AddLast(element);
        }

        internal T Dequeue()
        {
            T first = list.RemoveFirst();
            return first;
        }

        internal T Peek()
        {
            return list.GetHeadValue();
        }

        internal void PrintQueue()
        {
            list.PrintListForQueue();
        }

        internal void AddElementsFromArray(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Enqueue(arr[i]);
            }
        }

    }
}
